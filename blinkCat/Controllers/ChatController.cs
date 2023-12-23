using Microsoft.AspNetCore.Mvc;

namespace blinkCat.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
