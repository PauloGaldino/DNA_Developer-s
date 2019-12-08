using System.Collections.Generic;
using Domain.Entities.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Services.Pessoas.Contatos.Telefones;

namespace Domain.Services.Pessoas.Contatos.Telefones
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneService(ITelefoneRepository telefoneRepository) : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        //public IEnumerable<Telefone> FindByPhoneNumber(string numeroTelefone)
        //{
        //   return _telefoneRepository.FindByPhoneNumber(numeroTelefone);
        //}
    }
}
