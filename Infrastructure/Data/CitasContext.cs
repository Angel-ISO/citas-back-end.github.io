using System.Reflection;
using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.config;
namespace Infrastructure.Data;
public class CitasContext : DbContext
{
    public CitasContext(DbContextOptions<CitasContext> options) : base(options)
    {
        
    }
    public DbSet<Usuario> ?Usuarios { get; set; }
    public DbSet<Tipo_documento> ?Tipo_Documentos { get; set; }
    public DbSet<Medico> ?Medicos { get; set; }
    public DbSet<Genero> ?Generos { get; set; }
    public DbSet<Estado_cita> ?Estado_Citas { get; set; }
    public DbSet<Especialidad> ?Especialidades { get; set; }
    public DbSet<Consultorio> ?Consultorios { get; set; }
    public DbSet<Cita> ?Citas { get; set; }
    public DbSet<Acudiente> ? Acudientes { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
          modelBuilder.ApplyConfiguration(new AcudienteConfiguration());
          modelBuilder.ApplyConfiguration(new GeneroConfiguration());
          modelBuilder.ApplyConfiguration(new TipoDocumentoConfiguration());
          modelBuilder.ApplyConfiguration(new CitaConfiguration());
         modelBuilder.ApplyConfiguration(new EstadoCitaConfiguration());
          modelBuilder.ApplyConfiguration(new MedicoConfiguration());
          modelBuilder.ApplyConfiguration(new EspecialidadConfiguration());
          modelBuilder.ApplyConfiguration(new ConsultorioConfiguration());


          
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}