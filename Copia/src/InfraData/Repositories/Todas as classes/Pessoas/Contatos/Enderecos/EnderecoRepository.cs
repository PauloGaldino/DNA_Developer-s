using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Enderecos;

namespace InfraData.Repositories.Pessoas.Contatos.Enderecos
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        //public IEnumerable<Endereco> FindByCepNumber(string cep)
        //{
        //    return Db.Enderecos.Where(e => e.CEP == cep );
        //}

        //public IEnumerable<Endereco> FindByStreetName(string ruaNome)
        //{
        //    return Db.Enderecos.Where(e => e.Logradouro == ruaNome);
        //}
    }
}
