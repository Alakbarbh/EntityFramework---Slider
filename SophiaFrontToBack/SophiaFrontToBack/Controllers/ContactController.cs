using Microsoft.AspNetCore.Mvc;

namespace SophiaFrontToBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
