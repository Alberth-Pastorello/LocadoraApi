using LocadoraApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Jogo> Jogos { get; set; }
    }
}
