using Microsoft.AspNetCore.Mvc;

namespace LoginAdmin.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Company()
        {
            return View();
        }
        public IActionResult We()
        {
            return View();
        }
    }
}
