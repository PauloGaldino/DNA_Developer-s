using Domain.Entities.Pessoas.Clientes;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetEspecialCustumer();
    }
}
