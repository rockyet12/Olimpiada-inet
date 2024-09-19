using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("Carrito")]
public class Carrito
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCarrito { get; set; }
    
    [ForeignKey("IdCliente")]
    [Required]
    public Cliente? Cliente{ get; set;}
}
