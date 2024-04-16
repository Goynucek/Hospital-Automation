using HastaneOtomasyonu.DataAccessLayer;
using HastaneOtomasyonu.EntityLayer.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace HastaneOtomasyonu.Controllers
{
    public class KliniklerController : Controller
    {
        Context c = new Context();

        public IActionResult Index(int id)
        {
            var cc = c.Kliniks.Where(x=> x.PoliklinikID == id).ToList();
            TempData["polinikID"] = id;
            return View(cc);
        }

        [HttpGet]
        public IActionResult KlinikEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KlinikEkle(Klinik p)
        {
            p.PoliklinikID = (int)TempData["polinikID"];
            c.Kliniks.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index","Klinikler", new { id = p.PoliklinikID});
        }
    }
}
