using System.Collections.Generic;
using Application.Interfaces.Pessoas.Tipos;
using Domain.Entities.Pessoas.Documentos;
using Domain.Interfaces.Repositories.Pessoas.Documentos;
using Domain.Services;

namespace Application.Applications.Pessoas.Tipos
{
    public class FisicaAppService : ServiceBase<DocumentoFisica>, IFisicaAppService
    {
        private readonly IFisicaRepository _fisicaRepository;
        public FisicaAppService(IFisicaRepository fisicaRepository) : base(fisicaRepository)
        {
            _fisicaRepository = fisicaRepository;
        }

        //public IEnumerable<DocumentoFisica> FIndByCpf(string cpf)
        //{
        //    return _fisicaRepository.FindByDocumentCpf(cpf);
        //}
    }
}
