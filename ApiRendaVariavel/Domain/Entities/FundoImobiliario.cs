using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ApiRendaVariavel.Domain.Enums;


namespace ApiRendaVariavel.Domain.Entities
{
    public class FundoImobiliario
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string? Ticker { get; set; }

        [StringLength(14)]
        public string? Cnpj { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FundoImobiliarioType? tipoFundoImobiliario { get; set; } //= FundoImobiliarioType.NAO_DEFINIDO;

        [StringLength(255)]
        public string? RazaoSocial { get; set; }

        [StringLength(255)]
        public string? Segmento { get; set; }

        [StringLength(50)]
        public string? PublicoAlvo { get; set; }

        [StringLength(50)]
        public string? Mandato { get; set; }

        [StringLength(50)]
        public string? PrazoDeDuracao { get; set; }

        [StringLength(30)]
        public string? TipoDeGestao { get; set; }
        public double? TaxaDeAdministracao { get; set; }
        public double? Vacancia { get; set; }
        public int? NumeroDeCotistas { get; set; }
        public int? CotasEmitidas { get; set; }
        public double? ValorPatrimonialPorCota { get; set; }
        public double? ValorPatrimonial { get; set; }
        public double? UltimoRendimento { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DataHoraUltimaAtualizacao { get; set; } = DateTime.Now;

    //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    //public DateTime? HoraUltimaAtualizacao = DateTime.Now;
}
}
