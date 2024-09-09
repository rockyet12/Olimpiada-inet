using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oli_inet;
[Table("Rol")]
public class Rol
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRol { get; set; }

    [Required]
    public string Name { get; set; }=string.Empty;
}