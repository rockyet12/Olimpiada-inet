using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oli_inet;
[Table("MetodoDePago")]
public class MetodoDePago
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdMetodo { get; set; }
    public string Name {get; set;}=string.Empty;
}