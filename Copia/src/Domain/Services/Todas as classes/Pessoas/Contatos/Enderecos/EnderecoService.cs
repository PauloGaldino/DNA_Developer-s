using Domain.Entities.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Services.Pessoas.Contatos.Enderecos;
using System.Collections.Generic;

namespace Domain.Services.Pessoas.Contatos.Enderecos
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IEnumerable<Endereco> FindByCep(string cep)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Endereco> FindByNameStreet(string rua)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Endereco> GetByAdress(IEnumerable<Endereco> enderecos)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
