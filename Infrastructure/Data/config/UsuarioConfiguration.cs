using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.config;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");
        builder.Property
        (p => p.Usu_id).IsRequired();

        builder.Property
        (p => p.Usu_name).IsRequired().HasMaxLength(50);

        builder.Property
        (p => p.Usu_second_name).IsRequired().HasMaxLength(80);

        builder.Property
        (p => p.Usu_first_last_name).IsRequired();

        builder.Property
        (p => p.Usu_second_last_name).IsRequired().HasMaxLength(100);

        builder.Property
        (p => p.Usu_telephone).IsRequired();


        builder.Property
        (p => p.Usu_email).IsRequired();


        builder.Property
        (p => p.Usu_gender).IsRequired();

         builder.Property
        (p => p.Usu_type_document).IsRequired();
         
          builder.Property
        (p => p.Usu_address).IsRequired();
        
    }
}

