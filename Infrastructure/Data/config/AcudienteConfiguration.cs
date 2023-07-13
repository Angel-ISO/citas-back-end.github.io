using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
{
    public void Configure(EntityTypeBuilder<Acudiente> builder)
    {
        builder.ToTable("acudiente");
        builder.Property
        (p => p.Attendant_cod).IsRequired();

        builder.Property
        (p => p.Attendant_telephone).IsRequired();

        builder.Property
        (p => p.Attendant_telephone).IsRequired().HasMaxLength(80);

        builder.Property
        (p => p.Attendant_fullname).IsRequired().HasMaxLength(80);
    }
}

