using Application.Interfaces.Pessoas.Contatos.Enderecos;
using Domain.Entities.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Pessoas.Contatos.Enderecos;
using Domain.Services;
using System.Collections.Generic;

namespace Application.Applications.Pessoas.Contatos.Enderecos
{
    public class EnderecoAppService : ServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoAppService(IEnderecoRepository enderecoRepository): base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        //public IEnumerable<Endereco> FindByCep(string cep)
        //{
        //    return _enderecoRepository.FindByCepNumber(cep);
        //}

        //public IEnumerable<Endereco> FindByStreet(string nomeRua)
        //{
        //    return _enderecoRepository.FindByStreetName(nomeRua);
        //}
    }
}
