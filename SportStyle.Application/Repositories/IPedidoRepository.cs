using SportStyle.Domain.Entities;
namespace SportStyle.Application.Repositories;

public interface IPedidoRepository
{
    void Crear();
    void Modificar(Pedido pedido);
    void Eliminar(int idpedido);
    void Estado(Pedido pedido);
    void Suma(float total);
}
