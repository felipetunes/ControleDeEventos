using ControleDeEventos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ControleDeEventos.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            UsuarioModel usuario;
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                usuario = new UsuarioModel();
            }
            else
            {
                usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
            }

            return View(usuario);
        }
    }
}
