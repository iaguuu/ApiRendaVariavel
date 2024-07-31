using ApiRendaVariavel.Domain.Entities;
using ApiRendaVariavel.Domain.Interfaces;
using ApiRendaVariavel.Infraestruture.Database;
using System.Data;

namespace ApiRendaVariavel.Domain.Service
{
    public class FundoImobiliarioService : IFundoImobiliarioService
    {
        private readonly RendaVariavelDbContext _dbContext;
        public FundoImobiliarioService(RendaVariavelDbContext rendaVariavelDBContext)
        {
            _dbContext = rendaVariavelDBContext;
        }
        public List<FundoImobiliario> AllFundosImobiliarios()
        {
            return _dbContext.FUNDOS_IMOBILIARIOS.ToList();
        }
        public FundoImobiliario searchByTicker(string ticker)
        {
            return _dbContext.FUNDOS_IMOBILIARIOS.Where(x => x.Ticker == ticker).FirstOrDefault();
        }

        public void Add(FundoImobiliario fundoImobiliario)
        {
            _dbContext.FUNDOS_IMOBILIARIOS.Add(fundoImobiliario);
            _dbContext.SaveChanges();
        }
        public void Delete(FundoImobiliario fundoImobiliario)
        {
            _dbContext.FUNDOS_IMOBILIARIOS.Remove(fundoImobiliario);
            _dbContext.SaveChanges();
        }
        public void Update(FundoImobiliario fundoImobiliario)
        {
            _dbContext.FUNDOS_IMOBILIARIOS.Update(fundoImobiliario);
            _dbContext.SaveChanges();
        }
    }
}
