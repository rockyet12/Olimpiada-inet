using SportStyle.Domain.Entities;

namespace SportStyle.Application.Services
{
    public interface IClienteService
    {
         Task<List<Cliente>> GetCliente();
         Task<List<Cliente>> GetClienteId(int clienteId);
         Task<List<Cliente>> GetClienteName(string clienteName);
         Task<List<Cliente>> GetClienteMail(string clienteMail);
         Task<List<Cliente>> GetClientePass(string clientePass);
    }
}