using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Pessoas.Documentos;
using Domain.Interfaces.Repositories.Pessoas.Documentos;

namespace InfraData.Repositories.Pessoas.Documentos
{
    public class FisicaRepository : RepositoryBase<DocumentoFisica>, IFisicaRepository
    {
        //public IEnumerable<DocumentoFisica> FindByDocumentCpf(string cpf)
        //{
        //    return Db.Fisicas.Where(f => f.Cpf == cpf);
        //}
    }
}
