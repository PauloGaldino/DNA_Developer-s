using Application.Interfaces;
using Domain.Entities.Pessoas.Clientes;
using Domain.Interfaces.Services.Pessoas;
using System.Collections.Generic;

namespace Application.Applications.Pessoas.Clientes
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
                : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> GetEspecialCustumer()
        {
            return _clienteService.GetSpecialCustumer(_clienteService.GetAll());
        }
    }
}
