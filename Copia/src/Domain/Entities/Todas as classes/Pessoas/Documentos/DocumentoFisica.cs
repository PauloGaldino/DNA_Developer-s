using System;
using System.Collections.Generic;

namespace Domain.Entities.Pessoas.Documentos
{

    public class DocumentoFisica
    {
        public DocumentoFisica()
        {

        }
        public int FisicaId { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    
        //Propriedade de navegação
        public ICollection<Pessoa> Pessoa { get; set; }
    }
}
