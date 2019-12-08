using System.Collections.Generic;

namespace Domain.Entities.ConfiguraPessoa.Pessoas
{
    public class PessoaTipo
    {
        public PessoaTipo()
        {

        }
        public int PessoaTipoId { get; set; }
        public string Descricao { get; set; }

        //==========Aqui ficam as chaves estrangeiras===========//
        public ICollection<Pessoa> Pessoas { get; set; }

    }
}
