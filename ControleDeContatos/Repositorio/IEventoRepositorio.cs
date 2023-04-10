using ControleDeEventos.Models;

namespace ControleDeEventos.Repositorio
{
    public interface IEventoRepositorio
    {
        EventoModel ListarPorId(int id);
        List<EventoModel> BuscarTodos();
        EventoModel Adicionar(EventoModel Evento);
        EventoModel Atualizar(EventoModel Evento);
        bool Apagar(int id);
    }
}
