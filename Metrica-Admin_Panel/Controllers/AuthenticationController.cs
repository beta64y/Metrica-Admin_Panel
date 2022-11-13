using Microsoft.AspNetCore.Mvc;

namespace Metrica_Admin_Panel.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RePassword()
        {
            return View();
        }

        public IActionResult LockScreen()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
    }
}
