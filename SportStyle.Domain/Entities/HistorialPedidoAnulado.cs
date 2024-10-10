using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("HistorialPedidoAnulado")]
public class HistorialPedidoAnulado :HistorialPedido
{
    [Required]
    [StringLength(255)]
    public string Motivo { get; set; }=string.Empty;

        public HistorialPedidoAnulado(Cliente cliente, int MetodoDePago, string calle, string ciudad, string provincia, string CodigoPostal, bool entregado, decimal MontoTotal, DateOnly FechaPedido, DateOnly FechaEntregado,string motivo ) : base(cliente, MetodoDePago, calle, ciudad, provincia, CodigoPostal, entregado, MontoTotal, FechaPedido, FechaEntregado)
    {
        Motivo = motivo;
        this.cliente= cliente;
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
