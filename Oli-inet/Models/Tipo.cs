using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Oli_inet;
[Table("Tipo")]
public class Tipo
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTipo {get; set;}
    
    [Required]
    public string Name {get; set;}=string.Empty;
}
