using Microsoft.AspNetCore.Mvc;

namespace SophiaFrontToBack.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
