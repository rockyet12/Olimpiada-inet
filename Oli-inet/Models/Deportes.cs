using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oli_inet;

[Table ("Deporte")]
public class Deporte
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDeporte {get; set;}
    
    [Required]
    [StringLength(50)]
    public string Name {get; set;}=string.Empty;
}
