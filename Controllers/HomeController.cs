using Microsoft.AspNetCore.Mvc;

namespace Bullbol.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
