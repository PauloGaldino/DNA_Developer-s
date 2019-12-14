using System.Collections.Generic;
using Application.Interfaces.Pessoas.Contatos.Emails;
using Domain.Entities.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Emails;
using Domain.Services;

namespace Application.Applications.Pessoas.Contatos.Emails
{
    public class EmailAppService : ServiceBase<Email>, IEmailAppService
    {
        private readonly IEmailRepository _emailRepository;
        public EmailAppService(IEmailRepository emailRepository) : base(emailRepository)
        {
            _emailRepository = emailRepository;
        }

        //public IEnumerable<Email> FindByEmail(string enderecoEmail)
        //{
        //    return _emailRepository.FindByEmailAdress(enderecoEmail);
        //}
    }
}
