using System.Collections.Generic;
using System.Linq;
using Domain.Entities.ConfiguraPessoa.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;

namespace InfraData.Repositories.Pessoas
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public IEnumerable<Pessoa> FindByName(string nome)
        {
            return Db.Pessoas.Where(p => p.Nome == nome);
        }
    }
}
