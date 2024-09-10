using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Oli_inet;
[Table("Factura")]
public class Factura
{
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdFactura { get; set; }

    [Required]
    [ForeignKey("IdPedido")] 
    public Pedido? pedido { get; set; }

    [Required]
    public DateOnly FechaFactura { get; set; }

    [Required]
    public DateOnly FechaPagar { get; set; }

    [Required]
    public int NumCuotas { get; set; }

    [Required]
    public decimal MontoAbonar { get; set; }

    [Required]
    public decimal MontoTotal { get; set; }

    [Required]
    public decimal Acumulado { get; set; }
    
    [Required]
    public bool Pagado { get; set; }

    [Required]
    public bool FacturaPagadoTotal { get; set; }

}
