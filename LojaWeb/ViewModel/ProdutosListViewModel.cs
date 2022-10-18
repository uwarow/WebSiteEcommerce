using LojaWeb.Models;

namespace LojaWeb.ViewModel
{
    public class ProdutosListViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
