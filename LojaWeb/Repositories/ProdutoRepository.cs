using LojaWeb.Models;
using LojaWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace LojaWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;

        public ProdutoRepository(ApplicationContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutosPreferidos => _context.Produtos.Where(p => p.IsProdutosPreferidos).Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId) => _context.Produtos.FirstOrDefault(l => l.ProdutoId == produtoId);
    }
}


