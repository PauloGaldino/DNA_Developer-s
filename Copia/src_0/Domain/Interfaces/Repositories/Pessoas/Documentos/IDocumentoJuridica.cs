using Domain.Entities.ConfiguraDocumento.Documentos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Documentos
{
    public interface IDocumentoJuridica : IRepositoryBase<DocumentoJuridica>
    {
        IEnumerable<DocumentoJuridica> FindByNomeFantasia(string nomeFantasia);
    }
}
