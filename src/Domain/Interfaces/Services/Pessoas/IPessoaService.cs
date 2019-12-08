using Domain.Entities.Pessoas;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Pessoas
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> GetByName(string nome);
    }
}
