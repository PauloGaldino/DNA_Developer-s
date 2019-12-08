using Domain.Entities.Pessoas.Documentos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Documentos
{
    public interface IJuridicaRepository : IRepositoryBase<DocumentoJuridica>
    {
        //IEnumerable<DocumentoJuridica> FindByDocumentCnpj(string cnpj);
    }
}
