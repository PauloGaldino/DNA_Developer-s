using Domain.Entities.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Pessoas.Contatos.Enderecos
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        IEnumerable<Endereco> GetByAdress(IEnumerable<Endereco> enderecos);
        IEnumerable<Endereco> FindByNameStreet(string rua);
        IEnumerable<Endereco> FindByCep(string cep);
    }
}
