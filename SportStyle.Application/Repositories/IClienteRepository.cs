using System.Linq.Expressions;
using SportStyle.Domain.Entities;

namespace SportStyle.Application.Repositories;

public interface IClienteRepository
{
    //Falta mas interfaces, pensando mas tras pasar el tiempo 
    
    Task<List<Cliente>> GetCliente(Expression<Func<Cliente, bool>>? expression = null);
    void RecuperarUsuario(int IdCliente,int CodigoRecuperacion);
    void CambiarApodo(int IdCliente, string Apodo);
    void CambiarEmail(int IdCliente, string Email);
    void CambiarTelefono(int IdCliente, string Telefono);
    void CambiarContraseña(int IdCliente, string ContraseñaActual, string NuevaContraseña);
    void CambiarNombre(int IdCliente, string Nombre);
    void CambiarApellido(int IdCliente, string Apellido);
    void CambiarDireccion(int IdCliente, string Direccion);
}