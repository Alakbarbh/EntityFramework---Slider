using EntityFramework___Slider_Practice_.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework___Slider_Practice_.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
    

        public DbSet<Slider> Sliders  { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
    }
}
