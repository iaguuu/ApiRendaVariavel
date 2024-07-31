using ApiRendaVariavel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiRendaVariavel.Infraestruture
{
    public class FundoImobiliarioConfiguration : IEntityTypeConfiguration<FundoImobiliario>
    {
        public void Configure(EntityTypeBuilder<FundoImobiliario> builder)
        {
            builder.ToTable("FUNDOS_IMOBILIARIOS");

            builder.HasKey(fi => fi.Id);
            builder.Property(f => f.Id)
                .HasColumnName("ID_FUNDO_IMOBILIARIO")
                .UseIdentityColumn(1, 1);

            builder.Property(fi => fi.Ticker)
               .IsRequired()
               .HasMaxLength(15)
               .HasColumnName("TICKER");

            builder.HasIndex(f => f.Ticker).IsUnique();

            builder.Property(fi => fi.Cnpj)
               .HasMaxLength(14)
               .HasColumnName("CNPJ");

            builder.Property(fi => fi.tipoFundoImobiliario)
                .HasConversion<string>()
                .HasMaxLength(50)
                .HasColumnName("TIPO_INVESTIMENTO");

            builder.Property(fi => fi.RazaoSocial)
                .HasMaxLength(255)
                .HasColumnName("RAZAO_SOCIAL");

            builder.Property(fi => fi.Segmento)
                .HasMaxLength(50)
                .HasColumnName("SEGMENTO");

            builder.Property(fi => fi.PublicoAlvo)
                .HasMaxLength(50)
                .HasColumnName("PUBLICO_ALVO");

            builder.Property(fi => fi.Mandato)
                .HasMaxLength(50)
                .HasColumnName("MANDATO");

            builder.Property(fi => fi.PrazoDeDuracao)
                .HasMaxLength(50)
                .HasColumnName("PRAZO_DURACAO");

            builder.Property(fi => fi.TipoDeGestao)
                .HasMaxLength(30)
                .HasColumnName("TIPO_GESTAO");

            builder.Property(fi => fi.TaxaDeAdministracao)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("TAXA_ADMINISTRACAO");

            builder.Property(fi => fi.Vacancia)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("VACANCIA");

            builder.Property(fi => fi.NumeroDeCotistas)
                .HasColumnType("int")
                .HasColumnName("NUMERO_COTISTAS");

            builder.Property(fi => fi.CotasEmitidas)
                .HasColumnType("int")
                .HasColumnName("COTAS_EMITIDAS");

            builder.Property(fi => fi.ValorPatrimonialPorCota)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("VALOR_PATRIMONIAL_POR_COTA");

            builder.Property(fi => fi.ValorPatrimonial)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("VALOR_PATRIMONIAL");

            builder.Property(fi => fi.UltimoRendimento)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("ULTIMO_RENDIMENTO");
    
            builder.Property(c => c.DataHoraUltimaAtualizacao)
                .HasColumnName("DATA_HORA_ULTIMA_ATUALIZACAO");
            
            //builder.Property(c => c.HoraUltimaAtualizacao)
            //    .IsRequired()
            //    .HasColumnType("time(0)")
            //    .HasColumnName("HORA_ULTIMA_ATUALIZACAO");
        }
    }
}
