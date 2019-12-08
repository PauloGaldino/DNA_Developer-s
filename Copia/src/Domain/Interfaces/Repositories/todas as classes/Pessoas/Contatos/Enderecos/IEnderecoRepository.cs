using Domain.Entities.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Pessoas.Contatos.Enderecos
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        //IEnumerable<Endereco> FindByStreetName(string ruaNome);
        //IEnumerable<Endereco> FindByCepNumber(string cep);

    }
}
