using Domain.Entities.Cadastro.Pessoas.Funcionarios.Setores;
using Domain.Entities.Compras;
using Domain.Entities.Vendas;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Cadastro.Pessoas.Funcionarios
{
    public class Funcionario
    {
        public Funcionario()
        {

        }
        public int FuncionarioId { get; set; }
        public DateTime DataAdmissao { get; set; }
        public bool Ativo { get; set; }

        public int SetorId { get; set; }
        public Setor Setores { get; set; }

        public int FuncionarioTipoId { get; set; }
        public FuncionarioTipo FuncionarioTipo { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public ICollection<NotaCompra> NotasCompras { get; set; }
        public ICollection<NotaVenda> NotasVendas { get; set; }
    }
}
