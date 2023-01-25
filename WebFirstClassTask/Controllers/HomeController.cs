using Microsoft.AspNetCore.Mvc;

namespace WebFirstClassTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
