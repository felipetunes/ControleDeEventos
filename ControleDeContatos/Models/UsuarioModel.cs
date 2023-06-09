﻿using ControleDeEventos.Enums;
using ControleDeEventos.Helper;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEventos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Login do usuário")]
        public string Login { get; set;}
        [Required(ErrorMessage = "Digite o Email do usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Selecione o Perfil do usuário")]
        public PerfilEnum? Perfil { get; set;}
        [Required(ErrorMessage = "Digite uma senha para o usuário")]
        public string Senha { get; set;}
        public DateTime DataCadastro { get; set;}
        public DateTime? DataAtualizacao { get; set;}
        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid().ToString().Substring(0,8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }

        public void SetNovaSenha(string novaSenha)
        {
            Senha = novaSenha.GerarHash();
        }
    }
}
