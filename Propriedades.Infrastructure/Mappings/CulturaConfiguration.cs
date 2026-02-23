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
    public class CulturaConfiguration : IEntityTypeConfiguration<Cultura>
    {
        public void Configure(EntityTypeBuilder<Cultura> builder)
        {
            builder.ToTable("Culturas");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(c => c.Nome)
                .IsUnique();

            builder.Property(c => c.Tipo)
                .HasMaxLength(100);
        }
    }

}
