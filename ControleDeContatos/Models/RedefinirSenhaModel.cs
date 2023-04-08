using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o Nome do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        public string Email { get; set; }
    }
}
