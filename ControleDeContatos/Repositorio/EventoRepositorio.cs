using ControleDeEventos.Data;
using ControleDeEventos.Models;

namespace ControleDeEventos.Repositorio
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private readonly BancoContext _context;
        public EventoRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }

        public EventoModel Adicionar(EventoModel Evento)
        {
            _context.Eventos.Add(Evento);
            _context.SaveChanges();
            
            return Evento;
        }

        public bool Apagar(int id)
        {
            EventoModel EventoDB = ListarPorId(id);

            if (EventoDB == null) throw new System.Exception("Houve um erro na deleção do Evento");

            _context.Eventos.Remove(EventoDB);
            _context.SaveChanges();

            return true;
        }

        public EventoModel Atualizar(EventoModel Evento)
        {
            EventoModel EventoDB = ListarPorId(Evento.Id);

            if(EventoDB == null) throw new System.Exception("Houve um erro na atualização do Evento");

            EventoDB.Nome = Evento.Nome;
            EventoDB.Descricao = Evento.Descricao;
            EventoDB.Data = Evento.Data;

            _context.Eventos.Update(EventoDB);
            _context.SaveChanges();

            return EventoDB;
        }

        public List<EventoModel> BuscarTodos()
        {
            return _context.Eventos.ToList();
        }

        public EventoModel ListarPorId(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.Id == id);
        }
    }
}
