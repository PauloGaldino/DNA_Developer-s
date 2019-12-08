using Domain.Entities.Pessoas.Clientes;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Pessoas
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetSpecialCustumer(IEnumerable<Cliente> clientes);
    }
}
