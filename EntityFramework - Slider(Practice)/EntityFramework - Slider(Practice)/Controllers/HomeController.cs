using EntityFramework___Slider_Practice_.Data;
using EntityFramework___Slider_Practice_.Models;
using EntityFramework___Slider_Practice_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework___Slider_Practice_.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo
            };
            return View(model);
        }

        
    }
}