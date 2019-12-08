using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Domain.Entities.Cadastro.Pessoas.Contatos
{
    public class Contato
    {
        public Contato()
        {

        }
        public int ContatoId { get; set; }


        //Chave Estrangeira /Chave de navegação
      
        public int EmailId { get; set; }
        public Email Email { get; set; }

        public int TelefoneId { get; set; }
        public Telefone Telefone { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }
    }

}
