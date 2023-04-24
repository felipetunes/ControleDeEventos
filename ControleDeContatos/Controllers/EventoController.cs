using ControleDeEventos.Filters;
using ControleDeEventos.Helper;
using ControleDeEventos.Migrations;
using ControleDeEventos.Models;
using ControleDeEventos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace ControleDeEventos.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoRepositorio _eventoRepositorio;
        private string _filePath;
        private readonly ISessao _sessao;

        public EventoController(IEventoRepositorio eventoRepositorio, IWebHostEnvironment env, ISessao sessao)
        {
            _eventoRepositorio = eventoRepositorio;
            _filePath = env.WebRootPath;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            List<EventoModel> eventos = _eventoRepositorio.BuscarTodos();
            return View(eventos);
        }

        public IActionResult Detalhe(int id)
        {
            EventoModel Evento = _eventoRepositorio.ListarPorId(id);

            Evento.Logged = false;
            if (_sessao.BuscarSessaoDoUsuario() != null)
            {
                Evento.Logged = true;
            }

            return View(Evento);
        }

        [PaginaParaUsuarioLogado]
        public IActionResult Criar()
        {
            return View();
        }

        [PaginaParaUsuarioLogado]
        public IActionResult Editar(int id)
        {
            EventoModel Evento = _eventoRepositorio.ListarPorId(id);
            return View(Evento);
        }

        [PaginaParaUsuarioLogado]
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
        public IActionResult Criar(EventoModel evento, IFormFile anexo)
        {
            try
            {
                if (!ValidaImagem(anexo))
                    return View(evento);

                var nome = SalvarArquivo(anexo);
                evento.Foto = nome;

             
                    _eventoRepositorio.Adicionar(evento);
                    TempData["MensagemSucesso"] = "Evento cadastrado com sucesso";
                    return RedirectToAction("Index");
                

                return View(evento);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o evento, tente novamente, detalhe do erro:{ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public string SalvarArquivo(IFormFile anexo)
        {
            var nome = Guid.NewGuid().ToString() + anexo.FileName;

            var filePath = _filePath + "\\fotos";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using(var stream = System.IO.File.Create(filePath +"\\" + nome))
            {
                anexo.CopyToAsync(stream);
            }

            return nome;
        }

        public bool ValidaImagem(IFormFile anexo)
        {
            switch(anexo.ContentType)
            {
                case "image/jpeg":
                    return true;
                case "image/bmp":
                    return true;
                case "image/gif":
                    return true;
                case "image/png":
                    return true;
                default:
                    return false;
                    break;
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
