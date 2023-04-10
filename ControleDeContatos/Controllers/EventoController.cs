using ControleDeEventos.Filters;
using ControleDeEventos.Models;
using ControleDeEventos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeEventos.Controllers
{
    [PaginaParaUsuarioLogado]
    public class EventoController : Controller
    {
        private readonly IEventoRepositorio _eventoRepositorio;
        public EventoController(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        public IActionResult Index()
        {
            List<EventoModel> Eventos = _eventoRepositorio.BuscarTodos();
            return View(Eventos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            EventoModel Evento = _eventoRepositorio.ListarPorId(id);
            return View(Evento);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            EventoModel Evento = _eventoRepositorio.ListarPorId(id);
            return View(Evento);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _eventoRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Evento apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não foi possível apagar o evento";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu evento, mais detalhes do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(EventoModel evento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _eventoRepositorio.Adicionar(evento);
                    TempData["MensagemSucesso"] = "Evento cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(evento);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o evento, tente novamente, detalhe do erro:{ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(EventoModel evento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _eventoRepositorio.Atualizar(evento);
                    TempData["MensagemSucesso"] = "Evento alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", evento);
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar o evento, tente novamente, detalhe do erro:{ex}";
                return RedirectToAction("Index");
            }
        }

    }
}
