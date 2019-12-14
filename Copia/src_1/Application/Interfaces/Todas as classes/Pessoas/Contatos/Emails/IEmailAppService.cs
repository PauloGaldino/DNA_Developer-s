using Domain.Entities.Pessoas.Contatos.Emails;
using System.Collections.Generic;

namespace Application.Interfaces.Pessoas.Contatos.Emails
{
    public interface IEmailAppService : IAppServiceBase<Email>
    {
       // IEnumerable<Email> FindByEmail(string enderecoEmail);
    }
}
