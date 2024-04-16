using HastaneOtomasyonu.DataAccessLayer;
using HastaneOtomasyonu.EntityLayer.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace HastaneOtomasyonu.Controllers
{
    public class loginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Giris g)
        {
            var cc = c.Girises.FirstOrDefault(x=>x.Username == g.Username && x.Password == g.Password);
            if (cc != null)
            {
                HttpContext.Session.SetString("PersonelStatus", cc.Personel.Status.ToString());
                return RedirectToAction("Index","Admin");
            }
            return View();
        }
    }
}
