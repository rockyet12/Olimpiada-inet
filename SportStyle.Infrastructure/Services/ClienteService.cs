using SportStyle.Application.Repositories;
using SportStyle.Application.Services;
using SportStyle.Domain.Entities;

namespace SportStyle.Infrastructure.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _context;
    public ClienteService(IClienteRepository clienteRepository)
    {
        _context = clienteRepository;
    }

    public async Task<List<Cliente>> GetCliente()
        => await _context.GetCliente();

    public async Task<List<Cliente>> GetClienteId(int clienteId)
        => await _context.GetCliente(x => x.IdCliente ==clienteId);

    public async Task<List<Cliente>> GetClienteMail(string clienteMail)
        => await _context.GetCliente(x => x.Email == clienteMail);

    public async Task<List<Cliente>> GetClienteName(string clienteName)
        => await _context.GetCliente(x => x.Nombre == clienteName);
    public async Task<List<Cliente>> GetClientePass(string clientePass)
        => await _context.GetCliente(x => x.Password == clientePass);
}
