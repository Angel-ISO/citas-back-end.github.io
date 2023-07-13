using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("medico");
        builder.Property
        (p => p.Doctor_tuition).IsRequired();

        builder.Property
        (p => p.Doctor_fullName).IsRequired().HasMaxLength(50);

        
             builder.HasOne(u => u.Especialidad)
            .WithMany(a => a.Medicos)
            .HasForeignKey(u => u.Doctor_speciality)
            .IsRequired();


             builder.HasOne(u => u.Consultorio)
            .WithMany(a => a.Medicos)
            .HasForeignKey(u => u.Doctor_consroom)
            .IsRequired();
    }
}

