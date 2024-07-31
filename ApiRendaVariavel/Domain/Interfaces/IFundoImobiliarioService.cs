using ApiRendaVariavel.Domain.Entities;

namespace ApiRendaVariavel.Domain.Interfaces
{
    public interface IFundoImobiliarioService
    {
        List<FundoImobiliario> AllFundosImobiliarios();
        FundoImobiliario? searchByTicker(string ticker);
        void Add(FundoImobiliario fundoImobiliario);
        void Delete(FundoImobiliario fundoImobiliario);
        void Update(FundoImobiliario fundoImobiliario);
    }
}