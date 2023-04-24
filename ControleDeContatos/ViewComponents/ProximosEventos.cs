using ControleDeEventos.Models;
using ControleDeEventos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ControleDeEventos.ViewComponents
{
    public class ProximosEventos : ViewComponent
    {
        private readonly IEventoRepositorio _eventoRepositorio;
        public ProximosEventos(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<EventoModel> eventos = _eventoRepositorio.BuscarTodos();

            return View(eventos);
        }
    }
}
