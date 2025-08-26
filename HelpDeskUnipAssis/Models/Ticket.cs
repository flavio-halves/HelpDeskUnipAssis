using System.ComponentModel.DataAnnotations;

namespace HelpDeskUnipAssis.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        public string Descricao { get; set; } = string.Empty;

        public DateTime DataAbertura { get; set; } = DateTime.Now;

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
