using System.Collections.Generic;

namespace Domain.Entities.Pessoas.Funcionarios
{
    public class FuncionarioTipo 
    {
        public FuncionarioTipo()
        {

        }
        public int FuncionarioTipoId { get; set; }
        public string Descricao { get; set; }

         public ICollection<Pessoa> Pessoas { get; set; }
    }
}
