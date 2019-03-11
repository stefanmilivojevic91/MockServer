using Microsoft.AspNetCore.Mvc;

namespace WebInterface.Controllers
{
    public class RouterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}