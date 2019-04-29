using Microsoft.AspNetCore.Mvc;

namespace CryptoWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}