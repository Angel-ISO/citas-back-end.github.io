using System.ComponentModel.DataAnnotations;

namespace Core.Entitities;
public class Tipo_documento
{
    [Key]
    public int Typedoc_id { get; set; }
    public string ?Typedoc_nombre { get; set; }
    public ICollection<Usuario> ?Usuarios { get; set; }

    public string ?Typedoc_abbreviation { get; set; }
}

