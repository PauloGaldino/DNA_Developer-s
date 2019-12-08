using Domain.Entities.Pessoas;
using System.Collections.Generic;

namespace Application.Interfaces.Pessoas
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> FindByName(string nome);
    }
}
