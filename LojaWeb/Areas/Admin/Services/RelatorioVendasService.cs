using LojaWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LojaWeb.Areas.Admin.Services
{
    public class RelatorioVendasService
    {
       
            private readonly ApplicationContext context;
            public RelatorioVendasService(ApplicationContext _context)
            {
                context = _context;
            }

            public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
            {
                var resultado = from obj in context.Pedidos select obj;

                if (minDate.HasValue)
                {
                    resultado = resultado.Where(x => x.PedidoEnviado >= minDate.Value);
                }

                if (maxDate.HasValue)
                {
                    resultado = resultado.Where(x => x.PedidoEnviado <= maxDate.Value);
                }

                return await resultado
                    .Include(l => l.PedidoItens)
                    .ThenInclude(l => l.Produto)
                    .OrderByDescending(x => x.PedidoEnviado)
                    .ToListAsync();
            }
        }
    }



