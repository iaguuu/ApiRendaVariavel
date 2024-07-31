using ApiRendaVariavel.Domain.DTOs;
using ApiRendaVariavel.Domain.Entities;
using ApiRendaVariavel.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiRendaVariavel.Domain.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FundosImobiliariosController : ControllerBase
    {
        private readonly IFundoImobiliarioService _fundoImobiliarioService;
        public FundosImobiliariosController(IFundoImobiliarioService fundosImobiliariosRepositorio)
        {
            _fundoImobiliarioService = fundosImobiliariosRepositorio;
        }

        [HttpGet]
        public ActionResult<List<FundoImobiliario>> AllFundosImobiliarios()
        {
            List<FundoImobiliario> fundosImobiliarios = _fundoImobiliarioService.AllFundosImobiliarios();
            return Ok(fundosImobiliarios);
        }

        [HttpGet("{ticker}")]
        public ActionResult<FundoImobiliario> SearchByTicker(string ticker)
        {
            FundoImobiliario? fundoImobiliario = _fundoImobiliarioService.searchByTicker(ticker);

            if (fundoImobiliario is null)
                return NotFound();  
            return Ok(fundoImobiliario);
        }

        [HttpPost]
        public ActionResult Add([FromBody] FundoImobiliarioDTO fundoImobiliarioDTO)
        { 
            FundoImobiliario fundoImobiliario = new FundoImobiliario
            {
                Ticker = fundoImobiliarioDTO.Ticker,
                Cnpj = fundoImobiliarioDTO.Cnpj,
                tipoFundoImobiliario = fundoImobiliarioDTO.tipoFundoImobiliario,
                Segmento = fundoImobiliarioDTO.Segmento,
                PublicoAlvo = fundoImobiliarioDTO.PublicoAlvo,
                Mandato = fundoImobiliarioDTO.Mandato,
                PrazoDeDuracao = fundoImobiliarioDTO.PrazoDeDuracao,
                TipoDeGestao = fundoImobiliarioDTO.TipoDeGestao,
                TaxaDeAdministracao = fundoImobiliarioDTO.TaxaDeAdministracao,
                NumeroDeCotistas = fundoImobiliarioDTO.NumeroDeCotistas,
                CotasEmitidas = fundoImobiliarioDTO.CotasEmitidas,
                ValorPatrimonialPorCota = fundoImobiliarioDTO.ValorPatrimonialPorCota,
                ValorPatrimonial = fundoImobiliarioDTO.ValorPatrimonial,
                UltimoRendimento = fundoImobiliarioDTO.UltimoRendimento,
                DataHoraUltimaAtualizacao = DateTime.Now
            };

            _fundoImobiliarioService.Add(fundoImobiliario);
            return Ok(fundoImobiliarioDTO);
        }

        [HttpPut("{ticker}")]
        public ActionResult Upadate([FromBody] FundoImobiliarioDTO fundoImobiliarioDTO, string ticker)
        {
            FundoImobiliario? fundoImobiliario = _fundoImobiliarioService.searchByTicker(ticker);

            if (fundoImobiliario is null)
                return NotFound();

            if (fundoImobiliario is not null && ticker != fundoImobiliarioDTO.Ticker)
                return Problem($"Não é possível alterar o ticker {ticker} para {fundoImobiliarioDTO.Ticker}, pois {ticker} já está cadastrado", statusCode: (int)HttpStatusCode.Conflict);
			
            fundoImobiliario.Cnpj = fundoImobiliarioDTO.Cnpj;
			fundoImobiliario.tipoFundoImobiliario = fundoImobiliarioDTO.tipoFundoImobiliario,
            fundoImobiliario.Segmento = fundoImobiliarioDTO.Segmento;
            fundoImobiliario.PublicoAlvo = fundoImobiliarioDTO.PublicoAlvo;
            fundoImobiliario.Mandato = fundoImobiliarioDTO.Mandato;
            fundoImobiliario.PrazoDeDuracao = fundoImobiliarioDTO.PrazoDeDuracao;
            fundoImobiliario.TipoDeGestao = fundoImobiliarioDTO.TipoDeGestao;
            fundoImobiliario.TaxaDeAdministracao = fundoImobiliarioDTO.TaxaDeAdministracao;
            fundoImobiliario.NumeroDeCotistas = fundoImobiliarioDTO.NumeroDeCotistas;
            fundoImobiliario.CotasEmitidas = fundoImobiliarioDTO.CotasEmitidas;
            fundoImobiliario.ValorPatrimonialPorCota = fundoImobiliarioDTO.ValorPatrimonialPorCota;
            fundoImobiliario.ValorPatrimonial = fundoImobiliarioDTO.ValorPatrimonial;
            fundoImobiliario.UltimoRendimento = fundoImobiliarioDTO.UltimoRendimento;
            fundoImobiliario.DataHoraUltimaAtualizacao = DateTime.Now;

            _fundoImobiliarioService.Update(fundoImobiliario);

            return Ok();
        }

        [HttpDelete("{ticker}")]
        public ActionResult Delete(string ticker)
        {
            FundoImobiliario? fundoImobiliario = _fundoImobiliarioService.searchByTicker(ticker);

            if (fundoImobiliario is null)
                return NotFound();

            _fundoImobiliarioService.Delete(fundoImobiliario);
            return NoContent();
        }
    }
}
