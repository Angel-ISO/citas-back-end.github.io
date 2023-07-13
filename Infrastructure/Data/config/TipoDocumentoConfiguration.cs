using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class TipoDocumentoConfiguration : IEntityTypeConfiguration<Tipo_documento>
{
    public void Configure(EntityTypeBuilder<Tipo_documento> builder)
    {
        builder.ToTable("tipo_documento");
        builder.Property
        (p => p.Typedoc_id).IsRequired();

        builder.Property
        (p => p.Typedoc_nombre).IsRequired();

        builder.Property
        (p => p.Typedoc_abbreviation).IsRequired().HasMaxLength(80);

    }
}

