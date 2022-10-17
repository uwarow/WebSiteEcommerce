using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWeb.Models
{
   
    public class Categoria
    {
        [Column("CategoriaId")]
        [Display(Name =("Código Categoria"))]
        public int CategoriaId { get; set; }

        [Column("CategoriaName")]
        [Display(Name = ("Nome Categoria"))]
        public string CategoriaName { get; set; }

        [Column("Descricao")]
        [Display(Name = ("Descricao"))]
        public string Descricao { get; set; }

        [Column("CategoriaId")]
        [Display(Name = ("Código Categoria"))]
        public List<Produto> Produtos { get; set; }
    }
}
