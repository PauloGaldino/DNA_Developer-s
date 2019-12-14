using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Producao;
using Domain.Interfaces.Repositories.Producao;

namespace InfraData.Repositories.Producao
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        //public IEnumerable<Produto> FindByProductName(string produtoNome)
        //{
        //    return Db.Produtos.Where(p =>p.Descricao == produtoNome);
        //}
    }
}