using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Cita
{
    [Key]
    public int Appointment_cod { get; set; }
    public DateTime Appointment_Date { get; set; }
    public int Appointment_state { get; set; }
    public Estado_cita ? Estado_Cita { get; set; }

    public ICollection<Usuario> ?Usuarios { get; set; }
    public int Appointment_Medic { get; set; }
    public Medico ?  Medico { get; set; }
    public int Appointment_Userdata { get; set; }
}

