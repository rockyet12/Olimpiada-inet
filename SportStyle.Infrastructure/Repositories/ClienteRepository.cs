using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SportStyle.Application.Repositories;
using SportStyle.Domain.Entities;

namespace SportStyle.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly OlimpiadasDbContext _context;
    public ClienteRepository(OlimpiadasDbContext olimpiadasDbContext)
    {
        _context = olimpiadasDbContext;
    }
    public async Task<List<Cliente>> GetCliente(Expression<Func<Cliente, bool>>? expression = null)
    {
        if (expression == null)
        {
            return await _context.Cliente.ToListAsync();
        }
        return await _context.Cliente.Where(expression).ToListAsync();
    }
}
