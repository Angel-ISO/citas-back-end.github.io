using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Estado_cita
{
    [Key]
    public int Appointmenstate_id { get; set; }
    public string ?Appointmenstate_name { get; set; }
    public ICollection<Cita> ?Citas { get; set; }

}

