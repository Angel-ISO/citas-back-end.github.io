using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Especialidad
{
    [Key]
    public int Speciality_id { get; set; }
    public string ? Speciality_name { get; set; }
    public ICollection<Medico> ?Medicos { get; set; }

}

