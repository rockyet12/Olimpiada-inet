using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.CompilerServices;

namespace SportStyle.Domain.Entities;
[Table("Producto")]
public class Producto
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Codigo { get; set; }

    [Required]
    [ForeignKey("IdTipo")]
    public Tipo? tipo { get; set; }

    [Required]
    [ForeignKey("IdCliente")]
    public Cliente? Cliente { get; set; }

    [Required]
    [ForeignKey("IdDeporteDiv")]
    public DeporteDivision? deporteDivision { get; set; }

    [Required]
    public int Stock { get; set;}

    [Required]
    [StringLength(80)]
    public string Name {get; set;}=string.Empty;

    [Required]
    [StringLength(255)]
    public string Descripcion { get; set; }=string.Empty;


    [Required]
    [StringLength(50)]
    public string Color { get; set; }=string.Empty;

    [Required]
    public int Talle { get; set; }

    [Required]
    public int Cuotas { get; set; }

    [Required]
    public DateOnly FechaPublicacion { get; set; }

    [Required]
    public decimal PrecioUnitario { get; set; }

    public Producto(int codigo,Tipo tipo,Cliente cliente,DeporteDivision deporteDivision,int Stock,string name,string descripcion,string color,int talle,int cuotas,DateOnly FechaPublicacion,decimal PrecioUnitario)
    {
        Codigo = codigo;
        this.tipo = tipo;
        Cliente = cliente;
        this.deporteDivision = deporteDivision;
        this.Stock = Stock;
        Name = name;
        Descripcion = descripcion;
        Color = color;
        Talle = talle;
        Cuotas = cuotas;
        this.FechaPublicacion = FechaPublicacion;
        this.PrecioUnitario = PrecioUnitario;

    }

    public Producto(string motivo, Tipo tipo, Cliente cliente, string name, string descripcion, string color, int talle, int cuotas, int stock, DateOnly fechaPublicacion, DeporteDivision deporteDivision, decimal precioUnitario)
    {
        this.tipo = tipo;
        Cliente = cliente;
        Name = name;
        Descripcion = descripcion;
        Color = color;
        Talle = talle;
        Cuotas = cuotas;
        Stock = stock;
        FechaPublicacion = fechaPublicacion;
        this.deporteDivision = deporteDivision;
        PrecioUnitario = precioUnitario;
    }
}
