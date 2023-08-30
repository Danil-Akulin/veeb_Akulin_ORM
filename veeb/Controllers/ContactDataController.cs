using Microsoft.AspNetCore.Mvc;

namespace veeb.Controllers
{
    public class ContactDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
