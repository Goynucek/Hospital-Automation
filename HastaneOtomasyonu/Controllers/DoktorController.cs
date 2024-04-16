using HastaneOtomasyonu.BusinessLayer;
using HastaneOtomasyonu.DataAccessLayer;
using HastaneOtomasyonu.EntityLayer.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace HastaneOtomasyonu.Controllers
{
    public class DoktorController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var id = 1;
            var cc = c.Muayanes.Include(x=>x.hasta).Where(x=>x.PoliklinikID==id && x.Teshis == null).ToList();

            var i = 0;
            foreach (var x in cc)
            {
                cc[i].hasta.HastaSoyadı = Encrypte.Decrypt(x.hasta.HastaSoyadı);
                i++;
            }

            return View(cc);
        }

        public IActionResult HastaGecmis(int id)
        {
            var cc = c.Muayanes.Where(x=>x.HastaID == id).ToList();
            return View(cc);
        }

        [HttpGet]
        public IActionResult Teshis(int id)
        {
            var cc = c.Muayanes.Find(id);
            return View(cc);
        }

        [HttpPost]
        public IActionResult Teshis(Muayane m)
        {
            var cc = c.Muayanes.Find(m.MuayaneId);
            cc.Teshis=m.Teshis;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult TeshisDetay(int id)
        {
            var cc = c.Muayanes.Find(id);
            return View(cc);
        }
    }
}
