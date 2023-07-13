using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.config;
public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("genero");
        builder.Property
        (p => p.Gen_Id).IsRequired();

        builder.Property
        (p => p.Gen_abbreviation).IsRequired();

        builder.Property
        (p => p.Gen_Name).IsRequired().HasMaxLength(80);
    }
}

