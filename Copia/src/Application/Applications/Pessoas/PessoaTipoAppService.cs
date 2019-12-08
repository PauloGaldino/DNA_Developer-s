using Application.Interfaces.Pessoas;
using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas
{
    public class PessoaTipoAppService : ServiceBase<PessoaTipo>, IPessoaTipoAppService
    {
        private readonly IPessoaTipoRepository _pessoaTipoRepository;
        public PessoaTipoAppService(IPessoaTipoRepository pessoaTipoRepository) :base(pessoaTipoRepository)
        {
            _pessoaTipoRepository = pessoaTipoRepository;
        }
    }
}
