using Microsoft.AspNetCore.Mvc;

namespace SophiaFrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
