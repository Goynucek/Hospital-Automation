using Microsoft.AspNetCore.Mvc;

namespace HastaneOtomasyonu.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModalDeneme()
        {
            return View();
        }
    }
}
