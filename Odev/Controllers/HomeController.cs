using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Odev.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Deneme()
        {
            return View();
        }

    }
}
