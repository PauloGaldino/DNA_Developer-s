using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Producao
{
   public interface IProdutoRepository : IRepositoryBase<Produto>
    {
       // IEnumerable<Produto> FindByProductName(string produtoNome);
    }
}
