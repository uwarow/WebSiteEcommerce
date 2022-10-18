using LojaWeb.Models;
using LojaWeb.Repositories.Interfaces;
using LojaWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LojaWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.Produtos.OrderBy(l => l.ProdutoId);
                categoriaAtual = "Todos os Produtos";
            }
            else
            {
                produtos = _produtoRepository.Produtos
                    .Where(l => l.Categoria.CategoriaName.Equals(categoria))
                    .OrderBy(c => c.Nome);

              
                categoriaAtual = categoria;
            }

            var produtosListViewModel = new ProdutosListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            };

            return View(produtosListViewModel);
        }

        public IActionResult Details(int produtoId)
        {
            var produto= _produtoRepository.Produtos.FirstOrDefault(l => l.ProdutoId == produtoId);
            return View(produto);
        }
    }
}




