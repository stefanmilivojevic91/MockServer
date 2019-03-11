using Microsoft.AspNetCore.Mvc;

namespace WebInterface.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}