using Microsoft.AspNetCore.Mvc;

namespace Metrica_Admin_Panel.Controllers
{
    public class AppsController : Controller
    {
        public IActionResult calendar()
        {
            return View();
        }
        public IActionResult invoice()
        {
            return View();
        }
        public IActionResult contact_list()
        {
            return View();
        }
        public IActionResult chat()
        {
            return View();
        }
    }
}
