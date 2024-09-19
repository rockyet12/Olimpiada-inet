using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("MetodoDePago")]
public class MetodoDePago
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdMetodo { get; set; }
    public string Name {get; set;}=string.Empty;
}