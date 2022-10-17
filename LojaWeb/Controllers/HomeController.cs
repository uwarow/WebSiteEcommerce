using LojaWeb.Models;
using LojaWeb.Repositories.Interfaces;
using LojaWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LojaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProdutoRepository produtoRepository)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProdutosPreferidos = _produtoRepository.ProdutosPreferidos
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}