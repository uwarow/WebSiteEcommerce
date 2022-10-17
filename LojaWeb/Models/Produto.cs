using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWeb.Models
{
    [Table("Produtos")]
    
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }


        [Required(ErrorMessage ="O Nome do produto deve ser informado !")]
        [Display(Name =("Nome Produto"))]
        public string Nome { get; set; }

        [Required(ErrorMessage ="A descrição do produto deve ser informada !")]
        [Display(Name = ("Descrição Do Produto"))]
        [MinLength(20)]
        [MaxLength(200)]
        public string DescricaoCurta { get; set; }


        [Required(ErrorMessage = "A descrição do produto deve ser informada !")]
        [Display(Name = ("Descriçao Do Produto Detalhada"))]
        [MinLength(20)]
        [MaxLength(500)]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço do produto deve ser informado !")]
        [Display(Name = ("Preço Do Produto"))]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Link da imagem deve ser preenchido !")]
        [Display(Name = ("Link da Imagem Normal"))]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "Link da imagem deve ser preenchido !")]
        [Display(Name = ("Link Da Imagem Do Produto"))]
        public string ImagemThumbNail { get; set; }

        [Required]
        [Display(Name = ("Preferido"))]
        public bool IsProdutosPreferidos { get; set; }

        [Required]
        [Display(Name = ("Produtos Em Estoque"))]
        public bool EmEstoque { get; set; }

 
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
