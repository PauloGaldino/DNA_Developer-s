using Domain.Entities.ConfiguraDocumento.Documentos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Documentos
{
    public interface IDocumentoFisica : IRepositoryBase<DocumentoFisica>
    {
        IEnumerable<DocumentoFisica> FindByCpf(string cpf);
        IEnumerable<DocumentoFisica> FindByRg(string rg);
    }
}
