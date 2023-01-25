using Microsoft.AspNetCore.Mvc;

namespace WebFirstClassTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
