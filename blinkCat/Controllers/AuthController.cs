using Microsoft.AspNetCore.Mvc;

namespace blinkCat.Controllers
{
    public class AuthController : Controller
    {

        public AuthController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}