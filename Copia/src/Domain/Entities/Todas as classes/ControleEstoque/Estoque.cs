using Domain.Entities.Producao;

namespace Domain.Entities.ControleEstoque
{
    public class Estoque
    {
        public Estoque()
        {

        }
        public int EstoqueId { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
