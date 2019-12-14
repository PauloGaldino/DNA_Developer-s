using Domain.Entities.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Application.Interfaces.Pessoas.Contatos.Telefones
{
    public interface ITelefoneAppService : IAppServiceBase<Telefone>
    {
       // IEnumerable<Telefone> FindByPhone(string numeroTelefone);
    }
}
