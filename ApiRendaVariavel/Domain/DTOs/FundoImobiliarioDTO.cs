using System.Text.Json.Serialization;
using ApiRendaVariavel.Domain.Enums;

namespace ApiRendaVariavel.Domain.DTOs
{
    public class FundoImobiliarioDTO
    {
        public string? Ticker { get; set; }

        public string? Cnpj { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FundoImobiliarioType? tipoFundoImobiliario { get; set; }// = FundoImobiliarioType.NAO_DEFINIDO;

        public string? RazaoSocial { get; set; }

        public string? Segmento { get; set; }

        public string? PublicoAlvo { get; set; }

        public string? Mandato { get; set; }

       // public string? TipoDeFundo { get; set; }

        public string? PrazoDeDuracao { get; set; }

        public string? TipoDeGestao { get; set; }

        public double? TaxaDeAdministracao { get; set; }

        public double? Vacancia { get; set; }

        public int? NumeroDeCotistas { get; set; }

        public int? CotasEmitidas { get; set; }

        public double? ValorPatrimonialPorCota { get; set; }

        public double? ValorPatrimonial { get; set; }

        public double? UltimoRendimento { get; set; }

        public DateTime? DataHoraUltimaAtualizacao { get; set; }
    }
}
