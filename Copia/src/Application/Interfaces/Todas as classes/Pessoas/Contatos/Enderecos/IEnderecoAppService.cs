using Domain.Entities.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Application.Interfaces.Pessoas.Contatos.Enderecos
{
    public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        //IEnumerable<Endereco> FindByCep(string cep);
        //IEnumerable<Endereco> FindByStreet(string nomeRua);
    }
}
