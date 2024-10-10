using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("HistorialProducto")]
public class HistorialProducto(string motivo, Tipo tipo, Cliente cliente, DeporteDivision deporteDivision, int Stock, string name, string descripcion, string color, int talle, int cuotas, DateOnly FechaPublicacion, decimal PrecioUnitario) : Producto(motivo,tipo,cliente,name,descripcion,color,talle,cuotas,Stock,FechaPublicacion,deporteDivision,PrecioUnitario)
{
    [Required]
    [StringLength(255)]
    public string Motivo { get; set; } = motivo;

}


