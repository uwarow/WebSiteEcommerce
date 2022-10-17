using LojaWeb.Models;

namespace LojaWeb.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutosPreferidos { get; }
       Produto GetProdutoById(int produtoId);
    }
}
