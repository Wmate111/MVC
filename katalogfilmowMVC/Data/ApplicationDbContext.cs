using katalogfilmowMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace katalogfilmowMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Filmy { get; set; }
    }
}