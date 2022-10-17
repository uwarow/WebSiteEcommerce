using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWeb.Models
{
    
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public string CarrinhoCompraId { get; set; }

    }
}
