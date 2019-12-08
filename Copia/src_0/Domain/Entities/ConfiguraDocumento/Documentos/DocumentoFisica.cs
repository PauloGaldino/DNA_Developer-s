using Domain.Entities.ConfiguraPessoa.Pessoas;
using System.Collections.Generic;

namespace Domain.Entities.ConfiguraDocumento.Documentos
{
    public class DocumentoFisica
    {
        public DocumentoFisica()
        {

        }
        public int FisicaId { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        //==========Aqui ficam as chaves estrangeiras===========//
        public ICollection<Pessoa> Pessoas { get; set; }


    }
}
