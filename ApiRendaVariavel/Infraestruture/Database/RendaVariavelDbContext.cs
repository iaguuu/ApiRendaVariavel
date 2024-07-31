using ApiRendaVariavel.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiRendaVariavel.Infraestruture.Database
{
    public class RendaVariavelDbContext : DbContext
    {
        public RendaVariavelDbContext(DbContextOptions<RendaVariavelDbContext> options) : base(options)
        {
        }
        public DbSet<FundoImobiliario> FUNDOS_IMOBILIARIOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FundoImobiliarioConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
