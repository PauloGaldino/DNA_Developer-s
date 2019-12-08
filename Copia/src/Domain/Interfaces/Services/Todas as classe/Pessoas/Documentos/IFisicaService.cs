using Domain.Entities.Pessoas.Documentos;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Pessoas.Documentos
{
    public interface IFisicaService :IServiceBase<DocumentoFisica>
    {
        IEnumerable<DocumentoFisica> GetByDocumentCpf(IEnumerable<DocumentoFisica> fisicas);
        IEnumerable<DocumentoFisica> FindByCpfNumber(string numeroCpf);
    }
}
