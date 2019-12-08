using Domain.Entities.Pessoas;
using Domain.Entities.Pessoas.Documentos;
using Domain.Interfaces.Repositories.Pessoas.Documentos;
using Domain.Interfaces.Services.Pessoas.Documentos;
using System.Collections.Generic;

namespace Domain.Services.Pessoas.Documentos
{
    public class JuridicaService : ServiceBase<DocumentoJuridica>, IJuridicaService
    {
        private readonly IJuridicaRepository _juridicaRepository;
        public JuridicaService(IJuridicaRepository juridicaRepository) : base(juridicaRepository)
        {
            _juridicaRepository = juridicaRepository;
        }

        //public IEnumerable<DocumentoJuridica> GetByDocumentCnpj(string cnpj)
        //{
        //    return _juridicaRepository.FindByDocumentCnpj(cnpj);
        //}
    }
}
