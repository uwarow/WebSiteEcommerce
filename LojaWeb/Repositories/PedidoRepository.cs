using LojaWeb.Models;
using LojaWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace LojaWeb.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(ApplicationContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public Pedido GetPedidoById(int pedidoId)
        {
            var pedido = _appDbContext.Pedidos.Include(pd => pd.PedidoItens
                         .Where(pd => pd.PedidoId == pedidoId))
                         .FirstOrDefault(p => p.PedidoId == pedidoId);

            return pedido;
        }

        public List<Pedido> GetPedidos()
        {
            return _appDbContext.Pedidos.ToList();
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            //pedido.PedidoEntregueEm = DateTime.Now;

            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    ProdutoId = carrinhoItem.Produto.ProdutoId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Produto.Preco
                };
                _appDbContext.PedidoDetalhes.Add(pedidoDetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}