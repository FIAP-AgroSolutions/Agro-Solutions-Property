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
    public class SafraConfiguration : IEntityTypeConfiguration<Safra>
    {
        public void Configure(EntityTypeBuilder<Safra> builder)
        {
            builder.ToTable("Safras");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(s => s.Nome)
                .IsUnique();

            builder.Property(s => s.DataInicio)
                .IsRequired();

            builder.Property(s => s.DataFim)
                .IsRequired();
        }
    }
}
