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
    public class TalhaoConfiguration : IEntityTypeConfiguration<Talhao>
    {
        public void Configure(EntityTypeBuilder<Talhao> builder)
        {
            builder.ToTable("Talhoes");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(t => new { t.PropriedadeId, t.Codigo })
                .IsUnique();

            builder.Property(t => t.AreaHectares)
                .HasColumnType("decimal(18,2)");

            builder.HasMany(t => t.TalhoesSafra)
                .WithOne(ts => ts.Talhao)
                .HasForeignKey(ts => ts.TalhaoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
