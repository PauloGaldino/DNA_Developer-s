using Domain.Entities.ConfiguraPessoa.Pessoas;
using System;
using System.Collections.Generic;

namespace Domain.Entities.ConfiguraDocumento.Documentos
{
    public class DocumentoJuridica
    {
        public DocumentoJuridica()
        {

        }
        public int JuridicaId { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataFundacao { get; set; }

        //==========Aqui ficam as chaves estrangeiras===========//
        public ICollection<Pessoa> Pessoas { get; set; }

    }
}
