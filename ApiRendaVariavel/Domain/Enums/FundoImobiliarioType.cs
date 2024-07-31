using System.ComponentModel;

namespace ApiRendaVariavel.Domain.Enums
{
    public enum FundoImobiliarioType
    {
        [Description("FUNDO IMOBILIARIO")]
        FII,
        [Description("FUNDO DE INVESTIMENTO EM INFRAESTRUTURA")]
        FII_INFRA,
        [Description("FUNDO DE INVESTIMENTO EM CADEIAS AGROINDÚSTRIAIS")]
        FII_AGRO,
        [Description("NAO DEFINIDO")]
        NAO_DEFINIDO
    }
}
