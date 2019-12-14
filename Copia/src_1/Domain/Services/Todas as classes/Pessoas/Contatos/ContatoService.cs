using Domain.Entities.Pessoas.Contatos;
using Domain.Interfaces.Repositories.Pessoas.Contatos;
using Domain.Interfaces.Services.Pessoas.Contatos;

namespace Domain.Services.Pessoas.Contatos
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoService(IContatoRepository contatoRepository):base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
