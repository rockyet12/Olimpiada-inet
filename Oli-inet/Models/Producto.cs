using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.CompilerServices;

namespace Oli_inet;
[Table("Producto")]
public class Producto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Codigo { get; set; }

    [Required]
    [ForeignKey("IdTipo")]
    public Tipo? tipo { get; set; }

    [Required]
    [ForeignKey("IdCliente")]
    public Cliente? Cliente { get; set; }

    [Required]
    [ForeignKey("IdDeporteDiv")]
    public DeporteDivision? deporteDivision { get; set; }

    [Required]
    public int Stock { get; set;}

    [Required]
    [StringLength(80)]
    public string Name {get; set;}=string.Empty;

    [Required]
    [StringLength(255)]
    public string Descripcion { get; set; }=string.Empty;


    [Required]
    [StringLength(50)]
    public string Color { get; set; }=string.Empty;

    [Required]
    public int Talle { get; set; }

    [Required]
    public int Cuotas { get; set; }

    [Required]
    public DateOnly FechaPublicacion { get; set; }

    [Required]
    public decimal PrecioUnitario { get; set; }
}
