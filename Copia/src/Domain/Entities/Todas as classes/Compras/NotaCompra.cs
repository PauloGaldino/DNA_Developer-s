using Domain.Entities.Pessoas.Fornecedores;
using Domain.Entities.Pessoas.Funcionarios;
using System;

namespace Domain.Entities.Compras
{
    public class NotaCompra
    {
        public NotaCompra()
        {

        }
        public int notaCompraId { get; set; }
        public DateTime DataVenda { get; set; }
        public float valorTotal { get; set; }
        public int NumeroNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DateVencimento { get; set; }
        public Decimal Desconto { get; set; }
        public Decimal ValorDesconto { get; set; }
        public Decimal Ipi { get; set; }
        public DateTime DataCadastro { get; set; }

         public int FuncionarioId { get; set; }
         public Funcionario Funcionarios { get; set; }

         public int FornecedorId { get; set; }
         public Fornecedor Fornecedores { get; set; }

    }
}
