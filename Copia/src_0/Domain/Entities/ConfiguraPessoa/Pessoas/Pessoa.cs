using Domain.Entities.ConfiguraDocumento.Documentos;
using System;

namespace Domain.Entities.ConfiguraPessoa.Pessoas
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //==========Aqui ficam as chaves estrangeiras===========//
        public int PessoaTipoId { get; set; }
        public PessoaTipo PessoaTIpo { get; set; }

        public int FisicaId { get; set; }
        public DocumentoFisica DocumentoFisicas { get; set; }

        public int JuridicaId { get; set; }
        public DocumentoJuridica DocumentoJuridicas { get; set; }

    }
}
