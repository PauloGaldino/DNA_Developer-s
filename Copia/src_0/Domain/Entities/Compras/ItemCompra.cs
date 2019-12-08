using Domain.Entities.Producao;
using Domain.Entities.Vendas;

namespace Domain.Entities.Compras
{
    public class ItemCompra
    {
        public ItemCompra()
        {

        }
        public int ItemCompraId { get; set; }
        public int Quantdade { get; set; }
        public float Valor { get; set; }

        public int NotaVendaId { get; set; }
        public NotaVenda NotasVendas { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produtos { get; set; }
    }
}
