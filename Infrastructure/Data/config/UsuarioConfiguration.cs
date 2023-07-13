using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.config;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuario");
        builder.Property
        (p => p.Usu_id).IsRequired();

        builder.Property
        (p => p.Usu_name).IsRequired().HasMaxLength(50);

        builder.Property
        (p => p.Usu_second_name).IsRequired().HasMaxLength(50);

        builder.Property
        (p => p.Usu_first_last_name).IsRequired().HasMaxLength(50);

        builder.Property
        (p => p.Usu_second_last_name).IsRequired().HasMaxLength(50);

        builder.Property
        (p => p.Usu_telephone).IsRequired();


        builder.Property
        (p => p.Usu_email).IsRequired();


          builder.Property
        (p => p.Usu_address).IsRequired();

             builder.HasOne(y => y.Tipo_Documento)
            .WithMany(l => l.Usuarios)
            .HasForeignKey(z => z.Usu_type_document)
            .IsRequired();

             builder.HasOne(e => e.Genero)
            .WithMany(o => o.Usuarios)
            .HasForeignKey(x => x.Usu_gender)
            .IsRequired();

             builder.HasOne(u => u.Acudiente)
            .WithMany(a => a.Usuarios)
            .HasForeignKey(u => u.Usu_attendant)
            .IsRequired();


    }
}

