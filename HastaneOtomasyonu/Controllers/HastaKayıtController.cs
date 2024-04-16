using HastaneOtomasyonu.BusinessLayer;
using HastaneOtomasyonu.DataAccessLayer;
using HastaneOtomasyonu.EntityLayer.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography;
using System.Text;

namespace HastaneOtomasyonu.Controllers
{
    public class HastaKayıtController : Controller
    {
        Context c = new Context();
        Encrypte e = new Encrypte();

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(Hasta p)
        {
            string cc = Sorgula(p);
            return RedirectToAction(cc);
        }

        public string Sorgula(Hasta p)
        {
            var EHastaTCNO = Encrypte.Encrypt(p.HastaTCNO);
            var cc = c.Hastas.FirstOrDefault(x => x.HastaTCNO == EHastaTCNO);
            if (cc != null)
            {
                TempData["Hasta"] = cc.HastaID;
                return "PoliklinikSec";
            }
            else
            {
                return "HastaEkle";
            }
        }

        public IActionResult Randevu(int id)
        {
            TempData["pid"] = id;
            var cc = c.Kliniks.Where(x=>x.PoliklinikID == id).ToList();
            return View(cc);
        }

        public IActionResult RandevuAlındı(int id)
        {
            Muayane muayane = new Muayane();
            var hastaId = TempData["Hasta"];
            muayane.MuayaneZamanı = DateTime.Now;
            muayane.HastaID = (int)hastaId;
            muayane.KlinikID = id;
            muayane.PoliklinikID = (int)TempData["pid"];
            c.Muayanes.Add(muayane);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PoliklinikSec()
        {
            var cc = c.Polikliniks.ToList();
            return View(cc);
        }

        [HttpGet]
        public IActionResult HastaEkle(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kliniks.Where(x=>x.PoliklinikID == id).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KlinikAdı,
                                               Value = x.KlinikID.ToString()
                                           }).ToList();

            TempData["polinikID"] = id;

            ViewBag.dgr1 = deger1;
            return View();
        }

        [HttpPost]
        public IActionResult HastaEkle(Hasta p)
        {
            p.HastaTCNO = Encrypte.Encrypt(p.HastaTCNO);
            p.HastaSoyadı = Encrypte.Encrypt(p.HastaSoyadı);


            c.Hastas.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
