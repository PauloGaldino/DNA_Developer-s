using Domain.Entities.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Contatos.Telefones
{
    public interface ITelefoneRepository : IRepositoryBase<Telefone>
    {
        //IEnumerable<Telefone> FindByPhoneNumber(string numeroTelefone);
    }
}
