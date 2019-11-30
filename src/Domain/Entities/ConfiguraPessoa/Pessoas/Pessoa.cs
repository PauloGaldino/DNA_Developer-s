using System;

namespace Domain.Entities.ConfiguraPessoa.Pessoas
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public int PessoaId { get; set; }
        public int Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //==========Aqui ficam as chaves estrangeiras===========//
        
    }
}
