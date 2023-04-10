using ControleDeEventos.Filters;
using ControleDeEventos.Helper;
using ControleDeEventos.Models;
using ControleDeEventos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleDeEventos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISessao _sessao;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public HomeController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = new UsuarioModel();

            usuarioLogado = _sessao.BuscarSessaoDoUsuario();

            if (_sessao.BuscarSessaoDoUsuario() != null)
            {
                usuarioLogado = _sessao.BuscarSessaoDoUsuario();
            }
            return View(usuarioLogado);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}