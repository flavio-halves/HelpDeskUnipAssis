using Microsoft.AspNetCore.Mvc.RazorPages;
using HelpDeskUnipAssis.Data;
using HelpDeskUnipAssis.Models;

namespace HelpDeskUnipAssis.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Usuario Usuario { get; set; }

        public async Task OnGetAsync(int id)
        {
            Usuario = await _context.Usuarios.FindAsync(id);
        }
    }
}
