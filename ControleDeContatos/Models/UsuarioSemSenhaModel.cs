using ControleDeEventos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEventos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Login do usuário")]
        public string Login { get; set;}
        [Required(ErrorMessage = "Digite o Email do usuário")]
        public string Email { get; set;}
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        [Required(ErrorMessage = "Selecione o Perfil do usuário")]
        public PerfilEnum Perfil { get; set;}
    }
}
