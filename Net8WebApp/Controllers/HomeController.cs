using Microsoft.AspNetCore.Mvc;

namespace WebAppEmty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
