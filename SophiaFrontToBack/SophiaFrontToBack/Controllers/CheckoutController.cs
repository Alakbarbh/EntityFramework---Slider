using Microsoft.AspNetCore.Mvc;

namespace SophiaFrontToBack.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
