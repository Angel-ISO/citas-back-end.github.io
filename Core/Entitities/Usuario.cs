using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Usuario
{
    [Key]
    public int Usu_id { get; set; }
    public string ?Usu_name { get; set; }
    public string ?Usu_second_name { get; set;}
    public string ?Usu_first_last_name { get; set; }
    public string ?Usu_second_last_name { get; set; }
    public string ?Usu_telephone { get; set; }
    public string ?Usu_history { get; set; }
    public Cita ?Cita { get; set; }
    public string ?Usu_address { get; set; }
    public string ?Usu_email { get; set; }
    public int Usu_type_document { get; set; }
    public Tipo_documento ? Tipo_Documento { get; set; }
    public int Usu_gender { get; set; }
    public Genero ? Genero { get; set; }

      public int Usu_attendant { get; set; }
    public Acudiente ?Acudiente { get; set; }


}

