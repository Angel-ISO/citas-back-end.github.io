

using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Medico
{
    [Key]
    public int Doctor_tuition { get; set; }
    public string ? Doctor_fullName { get; set; }
    public int Doctor_consroom { get; set; }
    public int Doctor_speciality { get; set;}
}

