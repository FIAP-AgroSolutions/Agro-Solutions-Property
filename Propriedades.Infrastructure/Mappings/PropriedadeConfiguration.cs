using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Propriedades.Domain.Entities;

namespace Propriedades.Infrastructure.Mappings
{
    public class PropriedadeConfiguration : IEntityTypeConfiguration<Propriedade>

    {
        public void Configure(EntityTypeBuilder<Propriedade> builder)
        {
            builder.ToTable("Propriedades");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(p => p.Codigo)
                .IsUnique();

            builder.Property(p => p.Municipio)
                .HasMaxLength(100);

            builder.Property(p => p.Estado)
                .HasMaxLength(2);

            builder.Property(p => p.AreaTotalHectares)
                .HasColumnType("decimal(18,2)");

            builder.HasMany(p => p.Talhoes)
                .WithOne(t => t.Propriedade)
                .HasForeignKey(t => t.PropriedadeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
