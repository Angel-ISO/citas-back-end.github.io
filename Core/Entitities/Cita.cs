using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Cita
{
    [Key]
    public int Appointment_cod { get; set; }
    public DateTime Appointment_Date { get; set; }
    public int Appointment_state { get; set; }
    public int Appointment_doctor { get; set; }
    public int Appointment_Userdata { get; set; }
}

