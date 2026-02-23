using Microsoft.EntityFrameworkCore;
using Propriedades.Domain.Entities;
using System;

namespace Propriedades.Infrastructure.Data
{
    public class PropriedadesDbContext : DbContext
    {
        public PropriedadesDbContext(DbContextOptions<PropriedadesDbContext> options)
            : base(options) { }

        public DbSet<Propriedade> Propriedades { get; set; }
        public DbSet<Talhao> Talhoes { get; set; }
        public DbSet<Safra> Safras { get; set; }
        public DbSet<Cultura> Culturas { get; set; }
        public DbSet<TalhaoSafraCultura> TalhaoSafras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PropriedadesDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
