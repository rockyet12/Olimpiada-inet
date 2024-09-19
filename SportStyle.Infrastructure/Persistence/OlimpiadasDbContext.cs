using Microsoft.EntityFrameworkCore;
using SportStyle.Domain.Entities;
namespace SportStyle.Infrastructure;

public class OlimpiadasDbContext : DbContext
{
    public OlimpiadasDbContext(DbContextOptions<OlimpiadasDbContext> option) : base (option){}

    public DbSet<Carrito> Carrito { get; set; }
    public DbSet<CarritoProducto> CarritoProducto { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Deporte> Deporte { get; set; }
    public DbSet<DeporteDivision> DeporteDivision { get; set; }
    public DbSet<Division> Divison { get; set; }
    public DbSet<Factura> Factura { get; set; }
    public DbSet<HistorialPedido> HistorialPedido { get; set; }
    public DbSet<HistorialPedidoAnulado> HistorialPedidoAnulado { get; set; }
    public DbSet<HistorialProducto> HistorialProducto { get; set; }
    public DbSet<MetodoDePago> MetodosDePago { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<PedidoProducto> PedidoProducto { get; set; }
    public DbSet<Producto> Producto { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<Tipo> Tipo { get; set; }
    public DbSet<UsuarioNoValido> UsuarioNoValido { get; set; }
}
