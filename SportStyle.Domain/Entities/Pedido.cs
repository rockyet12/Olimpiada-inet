using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStyle.Domain.Entities;
[Table("Pedido")]
public class Pedido
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPedido { get; set; }

    [ForeignKey("IdCliente")]
    [Required]
    public Cliente? Cliente { get; set; } = null;

    [ForeignKey("IdMetodoDePago")]
    [Required]
    public MetodoDePago? MetodoDePago { get; set; } = null;

    [StringLength(50)]
    [Required]
    public string Calle { get; set; } = string.Empty;

    [StringLength(50)]
    [Required]
    public string Ciudad { get; set; } = string.Empty;

    [StringLength(50)]
    [Required]
    public string Provincia { get; set; } = string.Empty;

    [Required]
    public int CodigoP { get; set; }

    [Required]
    public bool Entregado { get; set; }

    [Required]
    public decimal MontoT { get; set; }

    [Required]
    public DateOnly FechaPedido { get; set; }

    [Required]
    public DateOnly FechaEntrega { get; set; }
}