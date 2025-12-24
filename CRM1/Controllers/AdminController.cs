using Microsoft.AspNetCore.Mvc;

namespace CRM1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminLogin()
        {
            return View();
        }
    }
}
