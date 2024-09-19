using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("HistorialPedidoAnulado")]
public class HistorialPedidoAnulado :HistorialPedido
{
    [Required]
    [StringLength(255)]
    public string Motivo { get; set; }=string.Empty;
}
