using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
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
    public bool Pagado { get; set; }//pagado o no pagado

    [Required]
    public bool FacturaPagadoTotal { get; set; }
    public Factura(Pedido pedido,DateOnly fechafactura, DateOnly fechapagar,int NumCuotas,decimal MontoAbonar,decimal MontoTotal, decimal acumulado,bool pagado, bool FacturaPagadoTotal) 
    {
        this.pedido = pedido;
        FechaFactura = fechafactura;
        FechaPagar = fechapagar;
        this.NumCuotas = NumCuotas;
        this.MontoAbonar = MontoAbonar;
        this.MontoTotal = MontoTotal;
        Acumulado = acumulado;
        Pagado = pagado;
        this.FacturaPagadoTotal = FacturaPagadoTotal;
    }

}