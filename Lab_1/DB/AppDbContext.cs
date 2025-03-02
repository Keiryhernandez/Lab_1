using Microsoft.EntityFrameworkCore;
using Lab_1.Models;

namespace Lab_1.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Alumnos> Alumnos { get; set; }
    }
    
}
