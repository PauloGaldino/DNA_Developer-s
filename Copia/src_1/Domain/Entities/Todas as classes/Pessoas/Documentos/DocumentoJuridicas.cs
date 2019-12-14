using System;
using System.Collections.Generic;

namespace Domain.Entities.Pessoas.Documentos
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

      
        public ICollection<Pessoa> Pessoa { get; set; }
    }
}
