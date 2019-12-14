using Domain.Entities.Compras;
using Domain.Entities.Producao;
using System;

namespace Domain.Entities.Vendas
{
    public class ItemVenda
    {
        public ItemVenda()
        {

        }
        public int ItemVendaId { get; set; }
        public int Quantidade { get; set; }
        public float ValorProduto { get; set; }
        public DateTime DataCadastro { get; set; }

        public int NotaCopmraId { get; set; }
        public NotaCompra NotaCompra { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produtos { get; set; }
    }
}
