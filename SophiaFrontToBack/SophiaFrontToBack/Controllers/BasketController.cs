using Microsoft.AspNetCore.Mvc;

namespace SophiaFrontToBack.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
