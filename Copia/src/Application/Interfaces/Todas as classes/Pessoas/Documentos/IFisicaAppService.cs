using Domain.Entities.Pessoas.Documentos;
using System.Collections.Generic;

namespace Application.Interfaces.Pessoas.Tipos
{
    public interface IFisicaAppService : IAppServiceBase<DocumentoFisica>
    {
        //IEnumerable<DocumentoFisica> FIndByCpf(string cpf);
    }
}
