using ControleDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do usuário")]
        public string Login { get; set;}
        [Required(ErrorMessage = "Digite a Senha do usuário")]
        public string Senha { get; set; }
    }
}
