using Domain.Entities.Pessoas.Documentos;
using System.Collections.Generic;

namespace Application.Interfaces.Pessoas.Documentos
{
    public interface IJuridicaAppService : IAppServiceBase<DocumentoJuridica>
    {
        //IEnumerable<DocumentoJuridica> FindByCnpj(string cnpj);
    }
}
