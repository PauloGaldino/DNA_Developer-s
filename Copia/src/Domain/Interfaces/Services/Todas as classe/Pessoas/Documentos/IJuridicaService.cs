using Domain.Entities.Pessoas.Documentos;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Pessoas.Documentos
{
    public interface IJuridicaService : IServiceBase<DocumentoJuridica>
    {
        //IEnumerable<DocumentoJuridica> GetByDocumentCnpj(string numeroCnpj);
    }
}
