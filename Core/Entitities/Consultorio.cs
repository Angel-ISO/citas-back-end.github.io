using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Consultorio
{
   [Key]
   public int Constroom_code { get; set; }
   public string ?Constroom_name { get; set; } 
}
