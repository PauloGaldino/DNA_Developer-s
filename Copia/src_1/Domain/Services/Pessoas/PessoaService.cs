using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;
using Domain.Interfaces.Services.Pessoas;

namespace Domain.Services.Pessoas
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }


        public IEnumerable<Pessoa> GetByName(string nome)
        {
            return _pessoaRepository.FindByName(nome);
        }
    }
}
