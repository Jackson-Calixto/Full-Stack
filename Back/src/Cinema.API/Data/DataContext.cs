
using Microsoft.EntityFrameworkCore;
using Cinema.API.Models;

namespace Cinema.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {}
        public DbSet<Filme> Filmes {get; set;}        
    }
}