using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Pessoas.Documentos;
using Domain.Interfaces.Repositories.Pessoas.Documentos;

namespace InfraData.Repositories.Pessoas.Documentos
{
    public class JuridicaRepository : RepositoryBase<DocumentoJuridica>, IJuridicaRepository
    {
        //public IEnumerable<DocumentoJuridica> FindByDocumentCnpj(string cnpj)
        //{
        //    return Db.Juridicas.Where(j =>j.Cnpj == cnpj);
        //}
    }
}
