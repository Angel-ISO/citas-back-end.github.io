using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Acudiente
{
    [Key]
    public int Attendant_cod { get; set; }
    public string ?Attendant_telephone { get; set; }
    public string ?Attendant_address { get; set; }
    public string ?Attendant_fullname { get; set; }
      public Usuario ? Usuario { get; set;}

}

