using SportStyle.Domain.Entities;
namespace SportStyle.Application.Repositories;

public interface IPedidoRepository
{
    void Crear(Pedido pedido);
    void Modificar(Pedido pedido);
    void Eliminar(int idpedido);
    void Estado(Pedido pedido);
    void Suma(float total);
}
