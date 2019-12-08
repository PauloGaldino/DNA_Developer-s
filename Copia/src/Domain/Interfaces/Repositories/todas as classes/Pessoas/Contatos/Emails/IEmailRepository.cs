using Domain.Entities.Pessoas.Contatos.Emails;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Contatos.Emails
{
    public interface IEmailRepository : IRepositoryBase<Email>
    {
        //IEnumerable<Email> FindByEmailAdress(string enderecoEmail);
    }
}
