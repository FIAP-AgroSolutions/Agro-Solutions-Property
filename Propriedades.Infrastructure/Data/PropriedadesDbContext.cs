using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Propriedades.Domain.Entities;
using System;

namespace Propriedades.Infrastructure.Data
{
    public class PropriedadesDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public PropriedadesDbContext(IConfiguration configuration) 
            : base()
        {
            _configuration = configuration;
        }

        public DbSet<Propriedade> Propriedades { get; set; }
        public DbSet<Talhao> Talhoes { get; set; }
        public DbSet<Safra> Safras { get; set; }
        public DbSet<Cultura> Culturas { get; set; }
        public DbSet<TalhaoSafraCultura> TalhaoSafras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PropriedadesDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
