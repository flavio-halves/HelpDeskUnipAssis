using Microsoft.EntityFrameworkCore;
using HelpDeskUnipAssis.Models;
using System.Collections.Generic;

namespace HelpDeskUnipAssis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
