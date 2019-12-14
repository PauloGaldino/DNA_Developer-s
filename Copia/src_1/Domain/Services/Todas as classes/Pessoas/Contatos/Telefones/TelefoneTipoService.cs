using Domain.Entities.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Services.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Domain.Services.Pessoas.Contatos.Telefones
{
    public class TelefoneTipoService : ServiceBase<TelefoneTipo>, ITelefoneTipoService
    {
        private readonly ITelefoneTipoRepository _telefoneTipoRepository;
        public TelefoneTipoService(ITelefoneTipoRepository telefoneTipoRepository) :base(telefoneTipoRepository)
        {
            _telefoneTipoRepository = telefoneTipoRepository;
        }
    }
}
