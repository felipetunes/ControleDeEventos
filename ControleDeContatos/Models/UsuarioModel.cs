using ControleDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Login do usuário")]
        public string Login { get; set;}
        [Required(ErrorMessage = "Digite o Email do usuário")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Selecione o Perfil do usuário")]
        public PerfilEnum Perfil { get; set;}
        [Required(ErrorMessage = "Digite uma senha para o usuário")]
        public string Senha { get; set;}
        public DateTime DataCadastro { get; set;}
        public DateTime? DataAtualizacao { get; set;}
    }
}
