using Application.Interfaces.Pessoas;
using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;
using Domain.Services;
using System.Collections.Generic;

namespace Application.Applications.Pessoas
{
    public class PessoaAppService : ServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaAppService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> FindByName(string nome)
        {
            return _pessoaRepository.FindByName(nome);
        }
    }
}
