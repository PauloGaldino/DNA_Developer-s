using Domain.Entities.Producao;
using Domain.Interfaces.Repositories.Producao;
using Domain.Interfaces.Services.Producao;

namespace Domain.Services.Producao
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository): base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
    }
}
