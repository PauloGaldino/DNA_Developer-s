using Domain.Entities.ConfiguraPessoa.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;
using Domain.Interfaces.Services.Pessoas;
using System.Collections.Generic;

namespace Domain.Services.Pessoas
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> FindByName(string nome)
        {
            return _pessoaRepository.FindByName(nome);
        }
    }
}
