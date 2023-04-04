using Microsoft.AspNetCore.Mvc;
using SophiaFrontToBack.Models;
using System.Diagnostics;

namespace SophiaFrontToBack.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}