using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Genero
{
    [Key]
    public int Gen_Id { get; set; }
    public string ?Gen_Name { get; set; }
    public string ?Gen_abbreviation { get; set; }
}

