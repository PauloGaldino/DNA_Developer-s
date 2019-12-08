using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Emails;
using Domain.Interfaces.Services.Pessoas.Contatos.Emails;

namespace Domain.Services.Pessoas.Contatos.Emails
{
    public class EmailService : ServiceBase<Email>, IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        public EmailService(IEmailRepository emailRepository): base(emailRepository)
        {
            _emailRepository = emailRepository;
        }

        //public IEnumerable<Email> FindByEmailAdress(string enderecoEmail)
        //{
        //    return _emailRepository.FindByEmailAdress(enderecoEmail);
        //}
    }
}
