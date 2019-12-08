using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;
using Domain.Interfaces.Services.Pessoas;

namespace Domain.Services.Pessoas
{
    public class PessoaTipoService : ServiceBase<PessoaTipo>, IPessoaTipoService
    {
        private readonly IPessoaTipoRepository _pessoaTipoRepository;
        public PessoaTipoService(IPessoaTipoRepository pessoaTipoRepository) :base(pessoaTipoRepository)
        {
            _pessoaTipoRepository = pessoaTipoRepository;
        }
    }
}
