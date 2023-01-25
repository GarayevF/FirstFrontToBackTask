using Microsoft.AspNetCore.Mvc;

namespace WebFirstClassTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
