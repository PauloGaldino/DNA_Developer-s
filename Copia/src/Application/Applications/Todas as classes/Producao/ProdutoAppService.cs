using Application.Interfaces.Producao;
using Domain.Entities.Producao;
using Domain.Interfaces.Services.Producao;
using System.Collections.Generic;

namespace Application.Applications.Producao
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        //public IEnumerable<Produto> FindByName(string nomeProduto)
        //{
        //    return _produtoService.FindByProductName(nomeProduto);
        //}
    }
}