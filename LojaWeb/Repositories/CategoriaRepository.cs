using LojaWeb.Models;
using LojaWeb.Repositories.Interfaces;

namespace LojaWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationContext _context;

        public CategoriaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
