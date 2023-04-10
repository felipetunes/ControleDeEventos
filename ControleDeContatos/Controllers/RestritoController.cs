using ControleDeEventos.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeEventos.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
