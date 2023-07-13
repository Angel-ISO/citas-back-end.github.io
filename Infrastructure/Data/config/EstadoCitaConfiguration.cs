using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class  EstadoCitaConfiguration : IEntityTypeConfiguration<Estado_cita>
{
    public void Configure(EntityTypeBuilder<Estado_cita> builder)
    {
        builder.ToTable("estado_cita");
        builder.Property
        (p => p.Appointmenstate_id).IsRequired();

    
        builder.Property
        (p => p.Appointmenstate_name).IsRequired().HasMaxLength(50);

      
    }
}

