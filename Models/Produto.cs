using System.ComponentModel.DataAnnotations;

namespace LojaGame_AspCore.Models
{
    public class Produto
    {
        [Display(Name = "Código", Description = "Código.")]
        public int IdProduto { get; set; }

        [Display(Name = "Nome do Produto", Description = "Nome do produto.")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string NomeProduto { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A Descrição é obrigatório")]
        public string DescricaoProduto { get; set; }

        [Display(Name = "Estoque", Description = "Estoque")]
        [Required(ErrorMessage = "A quantidade é obrigatório.")]
        public string QtdEstoque { get; set; }

        [Display(Name = "Imagem")]
        [Required(ErrorMessage = "A Imagem é obrigatório")]
        public string imagemProduto { get; set; }

        public Categoria RefCategoria { get; set; }
    }
}
