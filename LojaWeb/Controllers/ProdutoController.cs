using LojaWeb.Models;
using LojaWeb.Repositories.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace LojaWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ApplicationContext _context;



        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ApplicationContext context)
        {
            _produtoRepository = produtoRepository;
            _context = context;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos Os Produtos";
            ViewData["Data"] = DateTime.Now;
            var produtos = _produtoRepository.Produtos;
            var totalprodutos = produtos.Count();
            ViewBag.Total = "Total De Produtos";
            ViewBag.TotalProdutos = totalprodutos;
            return View(produtos);
        }
    }
}
       


