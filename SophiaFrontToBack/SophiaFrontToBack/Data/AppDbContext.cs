using Microsoft.EntityFrameworkCore;
using SophiaFrontToBack.Models;

namespace SophiaFrontToBack.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Slider> Sliders { get; set; }
    }

    
}
