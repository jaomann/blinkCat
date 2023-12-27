using AutoMapper;
using blinkCat.Models;
using blinkCore.Contracts.Entities;
using blinkCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blinkCat.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public AuthController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Index(string errorMessage)
        {
            ViewData["error"] = errorMessage;
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserViewModel model)
        {
            var real = _mapper.Map<User>(_userService.VerifyUser(model.Email));
            string errorMessage = "";
            if(real != null)
            {
                if(real.Password == model.Password)
                {
                    return RedirectToAction("Index", "Chat");
                }
                errorMessage = "Dados Invalidos.";
            }
            return RedirectToAction("Index", errorMessage);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            _userService.Create(_mapper.Map<User>(model));

            return RedirectToAction("Index");
        }
    }
}