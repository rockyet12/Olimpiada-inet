using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("CarritoProducto")]
public class CarritoProducto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdcarritoProducto { get; set; }

    [Required]
    [ForeignKey("IdCarrito")]
    public Carrito? Carrito { get; set; }

    [Required]
    public int Codigo { get; set; }

    [Required]
    public int Cantidad { get; set; }

    [Required]
    public bool Pagado { get; set; }
    public CarritoProducto(Carrito carrito, int cantidad,bool pagado)
    {
        Carrito=carrito;
        Cantidad = cantidad;
        Pagado = pagado;
    }
}
