using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class ConsultorioConfiguration : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
        builder.ToTable("consultorio");
        builder.Property
        (p => p.Constroom_code).IsRequired();

    
        builder.Property
        (p => p.Constroom_name).IsRequired().HasMaxLength(50);

      
    }
}

