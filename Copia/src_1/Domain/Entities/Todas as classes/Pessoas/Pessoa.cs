using Domain.Entities.Pessoas.Contatos;
using System.Collections.Generic;
using System;
using Domain.Entities.Pessoas.Clientes;
using Domain.Entities.Pessoas.Funcionarios;
using Domain.Entities.Pessoas.Documentos;

namespace Domain.Entities.Pessoas
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public int PessoaId { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }


        
        ////Chave estrangeira 
      
        public int PessoaTipoId { get; set; }
        public PessoaTipo PessoaTipo { get; set; }

        public int ContatoId { get; set; }
        public Contato Contatos { get; set; }

        public int FisicaId { get; set; }
        public DocumentoFisica DocumentoFisica { get; set; }
        public int JuridicaId { get; set; }
        public DocumentoJuridica Documentouridica { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }

    }
}
