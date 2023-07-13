using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class  EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
        builder.ToTable("especialidad");
        builder.Property
        (p => p.Speciality_id).IsRequired();

    
        builder.Property
        (p => p.Speciality_name).IsRequired().HasMaxLength(50);

      
    }
}

