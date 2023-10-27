using Microsoft.AspNetCore.Mvc;

namespace magazyn_v1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
