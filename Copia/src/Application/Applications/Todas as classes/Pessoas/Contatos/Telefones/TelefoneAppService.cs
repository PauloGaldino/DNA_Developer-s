using Application.Interfaces.Pessoas.Contatos.Telefones;
using Domain.Entities.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Telefones;
using Domain.Services;
using System.Collections.Generic;

namespace Application.Applications.Pessoas.Contatos.Telefones
{
    public class TelefoneAppService : ServiceBase<Telefone>, ITelefoneAppService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneAppService(ITelefoneRepository telefoneRepository) : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        //public IEnumerable<Telefone> FindByPhone(string numeroTelefone)
        //{
        //    return _telefoneRepository.FindByPhoneNumber(numeroTelefone);
        //}
    }
}
