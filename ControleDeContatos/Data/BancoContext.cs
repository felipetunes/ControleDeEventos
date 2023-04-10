using ControleDeEventos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEventos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options) : base(options)
        { 
        }

        public DbSet<EventoModel> Eventos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
