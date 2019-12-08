using Domain.Entities.ConfiguraPessoa.Pessoas;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> FindByName(string nome);
    }
}
