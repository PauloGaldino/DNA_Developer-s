using Domain.Entities.Pessoas.Contatos.Emails;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Pessoas.Contatos.Emails
{
    public interface IEmailService : IServiceBase<Email>
    {
        //IEnumerable<Email> FindByEmailAdress(string enderecoEmail);
    }
}
