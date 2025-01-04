using Microsoft.AspNetCore.Mvc;

namespace Bullbol.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpcomingEvents()
        {
            return View();
        }
        public IActionResult Archive()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult SingleUpcoming()
        {
            return View();
        }
        public IActionResult SingleFinished()
        {
            return View();
        }
    }
}
