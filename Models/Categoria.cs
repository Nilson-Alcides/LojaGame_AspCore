using System.ComponentModel.DataAnnotations;

namespace LojaGame_AspCore.Models
{
    public class Categoria
    {
        [Display(Name = "Código", Description = "Código.")]
        public int IdCategoria { get; set; }

        [Display(Name = "Categoria", Description = "Categoria")]
        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        public string NomeCategoria { get; set; }
    }
}
