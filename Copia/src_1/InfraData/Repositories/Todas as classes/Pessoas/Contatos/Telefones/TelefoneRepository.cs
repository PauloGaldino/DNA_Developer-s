using Domain.Entities.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Telefones;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories.Pessoas.Contatos.Telefones
{
    public class TelefoneRepository : RepositoryBase<Telefone>, ITelefoneRepository
    {
        //public IEnumerable<Telefone> FindByPhoneNumber(string numeroTelefone)
        //{
        //    return Db.Telefones.Where(t => t.Numero == numeroTelefone);
        //}
    }
}
