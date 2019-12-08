using System.Collections.Generic;

namespace Domain.Entities.Cadastro.Pessoas.Funcionarios.Setores
{
     public class Setor
    {
        public Setor()
        {

        }
        public int SetorId { get; set; }
        public string Local { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }

    }
}
