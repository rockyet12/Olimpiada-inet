using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SportStyle.Domain.Entities;
[Table("PedidoProducto")]
public class PedidoProducto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPedidoProducto { get; set; }

    [ForeignKey("IdPedido")]
    [Required]
    public Pedido? pedido { get; set; }
    
    [Required]
    public int Codigo { get; set; }
}
