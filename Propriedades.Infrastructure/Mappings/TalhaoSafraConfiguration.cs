using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Propriedades.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades.Infrastructure.Mappings
{
    public class TalhaoSafraConfiguration : IEntityTypeConfiguration<TalhaoSafraCultura>
    {
        public void Configure(EntityTypeBuilder<TalhaoSafraCultura> builder)
        {
            builder.ToTable("TalhoesSafra");

            builder.HasKey(ts => ts.Id);

            builder.HasIndex(ts => new { ts.TalhaoId, ts.SafraId })
                .IsUnique();

            builder.Property(ts => ts.ProducaoTotalToneladas)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(ts => ts.Safra)
                .WithMany(s => s.TalhoesSafra)
                .HasForeignKey(ts => ts.SafraId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ts => ts.Cultura)
                .WithMany(c => c.TalhoesSafra)
                .HasForeignKey(ts => ts.CulturaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
