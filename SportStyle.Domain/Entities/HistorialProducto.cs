using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("HistorialProducto")]
public class HistorialProducto : Producto
{
    [Required]
    [StringLength(255)]
    public string  Motivo { get; set; }=string.Empty;
}
