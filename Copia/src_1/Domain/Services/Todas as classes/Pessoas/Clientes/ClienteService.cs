using Domain.Entities.Pessoas.Clientes;
using Domain.Interfaces.Repositories.Pessoas.Clientes;
using Domain.Interfaces.Services.Pessoas;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services.Pessoas.Clientes
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository):base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetSpecialCustumer(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
