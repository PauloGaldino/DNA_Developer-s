using Application.Interfaces.Pessoas.Contatos.Telefones;
using Domain.Entities.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Telefones;
using Domain.Services;

namespace Application.Applications.Pessoas.Contatos.Telefones
{
    public class TelefoneTipoAppService : ServiceBase<TelefoneTipo>, ITelefoneTipoAppService
    {
        private readonly ITelefoneTipoRepository _telefoneTipoRepository;
        public TelefoneTipoAppService(ITelefoneTipoRepository telefoneTipoRepository) : base(telefoneTipoRepository)
        {
            _telefoneTipoRepository = telefoneTipoRepository;
        }
    }
}
