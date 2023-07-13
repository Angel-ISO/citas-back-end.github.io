using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.ToTable("cita");
        builder.Property
        (p => p.Appointment_cod).IsRequired();

        builder.Property
        (p => p.Appointment_Date).IsRequired();

        builder.Property
        (p => p.Appointment_Userdata).IsRequired();

        
         builder.HasOne(u => u.Medico)
            .WithMany(a => a.Citas)
            .HasForeignKey(u => u.Appointment_Medic)
            .IsRequired();

        builder.HasOne(u => u.Estado_Cita)
            .WithMany(a => a.Citas)
            .HasForeignKey(u => u.Appointment_state)
            .IsRequired();

    }
}

