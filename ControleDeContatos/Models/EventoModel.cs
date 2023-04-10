using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ControleDeEventos.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do evento")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a descrição do evento")]
        public string Descricao { get; set;}
        [Required(ErrorMessage = "Digite a data do evento")]
        public DateTime Data { get; set;}
    }
}
