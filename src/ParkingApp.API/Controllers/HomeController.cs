using Microsoft.AspNetCore.Mvc;

namespace ParkingApp.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
