using Domain.Entities.Compras;
using System.Collections.Generic;

namespace Domain.Entities.Pessoas.Fornecedores
{
    public class Fornecedor
    {
        public Fornecedor()
        {

        }
        public int FornecedorId { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public ICollection<NotaCompra> NotasCompras { get; set; }
    }
}
