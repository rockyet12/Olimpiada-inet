using System.Linq.Expressions;
using SportStyle.Domain.Entities;

namespace SportStyle.Application.Repositories;

public interface IClienteRepository
{
    Task<List<Cliente>> GetCliente(Expression<Func<Cliente, bool>>? expression = null);
}