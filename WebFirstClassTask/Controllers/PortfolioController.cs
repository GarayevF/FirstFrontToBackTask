using Microsoft.AspNetCore.Mvc;

namespace WebFirstClassTask.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
