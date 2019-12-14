using System.Collections.Generic;
using Application.Interfaces.Pessoas.Documentos;
using Domain.Entities.Pessoas.Documentos;
using Domain.Interfaces.Repositories.Pessoas.Documentos;
using Domain.Services;

namespace Application.Applications.Pessoas.Documentoss
{
    public class JuridicaAppService : ServiceBase<DocumentoJuridica>, IJuridicaAppService
    {
        private readonly IJuridicaRepository _juridicaRepository;
        public JuridicaAppService(IJuridicaRepository juridicaRepository): base(juridicaRepository)
        {
            _juridicaRepository = juridicaRepository;
        }
        
        //public IEnumerable<DocumentoJuridica> FindByCnpj(string cnpj)
        //{
        //    return _juridicaRepository.FindByDocumentCnpj(cnpj);
        //}
    }
}
