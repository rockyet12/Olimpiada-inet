using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("HistorialPedido")]
public class HistorialPedido
{
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPedidoH { get; set; }

    [Required]
    [ForeignKey("IdCliente")]
    public Cliente? cliente { get; set; }

    [Required]
    public int MetodoDePago { get; set; }

    [Required]
    [StringLength(50)]
    public string Calle { get; set; }=string.Empty;

    [Required]
    [StringLength(50)]
    public string Ciudad { get; set; }=string.Empty;

    [Required]
    [StringLength(50)]
    public string Provincia { get; set; }=string.Empty;

    [Required]
    [StringLength(50)]
    public string CodigoPostal { get; set; }=string.Empty;
    
    [Required]
    public bool Entregado { get; set; }

    [Required]
    public decimal MontoTotal { get; set; }

    [Required]
    public DateOnly FechaPedido { get; set; }

    [Required]
    public DateOnly FechaEntregado { get; set; }
    public HistorialPedido(Cliente cliente,int MetodoDePago,string calle,string ciudad,string provincia, string CodigoPostal,bool entregado, decimal MontoTotal, DateOnly FechaPedido,DateOnly FechaEntregado)
    {
        this.cliente = cliente;
        this.MetodoDePago = MetodoDePago;
        Calle = calle;
        Ciudad = ciudad;
        Provincia = provincia;
        this.CodigoPostal = CodigoPostal;
        Entregado = entregado;
        this.MontoTotal = MontoTotal;
        this.FechaPedido = FechaPedido;
        this.FechaEntregado = FechaEntregado;   
    }
}
