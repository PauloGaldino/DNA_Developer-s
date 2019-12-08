using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Emails;

namespace InfraData.Repositories.Pessoas.Contatos.Emails
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
        //public IEnumerable<Email> FindByEmailAdress(string enderecoEmail)
        //{
        //    return Db.Emails.Where(em => em.EnderecoEmail == enderecoEmail);
        //}
    }
}
