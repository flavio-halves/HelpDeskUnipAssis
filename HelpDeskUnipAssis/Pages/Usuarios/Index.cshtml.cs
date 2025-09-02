using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelpDeskUnipAssis.Data;
using HelpDeskUnipAssis.Models;

namespace HelpDeskUnipAssis.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Usuario> ListaUsuarios { get; set; } = new List<Usuario>();

        public async Task OnGetAsync()
        {
            ListaUsuarios = await _context.Usuarios.ToListAsync();
        }
    }
}
