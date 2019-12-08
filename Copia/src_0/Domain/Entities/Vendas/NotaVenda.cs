using Domain.Entities.Cadastro.Pessoas.Clientes;
using Domain.Entities.Cadastro.Pessoas.Funcionarios;
using Domain.Entities.Compras;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Vendas
{
    public class NotaVenda
    {
        public NotaVenda()
        {
                
        }
        public int NotaVendaId { get; set; }
        public float ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataCadastro { get; set; }
        public Decimal Desconto { get; set; }
        public Decimal Valor { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        public List<NotaCompra> NotasCompras { get; set; }

    }
}
