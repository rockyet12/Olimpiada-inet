namespace SportStyle.Application.Services;

public interface IPedidoService
{
    void Crear (int idpedido,int IdUsuario );
    void ObtenerPedido (int idpedido);
    void ModificarPedido (int idPedido, int IdUsuario);
}
