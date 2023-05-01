using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace marketDb.Models
{
    public class UrunContext:DbContext
    {
        public UrunContext()
        {
            
        }
        public UrunContext(DbContextOptions options)
        : base(options)
        {
            
        }

        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
