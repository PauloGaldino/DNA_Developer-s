using Domain.Entities.Pessoas.Documentos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Documentos
{
    public interface IFisicaRepository : IRepositoryBase<DocumentoFisica>
    {
        //IEnumerable<DocumentoFisica> FindByDocumentCpf(string cpf);
    }
}
