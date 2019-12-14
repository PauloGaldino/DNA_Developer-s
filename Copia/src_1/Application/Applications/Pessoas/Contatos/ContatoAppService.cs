using Application.Interfaces.Pessoas.Contatos;
using Domain.Entities.Pessoas.Contatos;
using Domain.Interfaces.Repositories.Pessoas.Contatos;
using Domain.Services;

namespace Application.Applications.Pessoas.Contatos
{
    public class ContatoAppService : ServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoAppService(IContatoRepository contatoRepository):base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
