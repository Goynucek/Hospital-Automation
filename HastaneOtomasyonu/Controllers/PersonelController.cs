using HastaneOtomasyonu.DataAccessLayer;
using HastaneOtomasyonu.EntityLayer.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using HastaneOtomasyonu.BusinessLayer;

namespace HastaneOtomasyonu.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        PasswordHasher b = new PasswordHasher();

        public IActionResult Index(int id)
        {
            var cc = c.Personels.Where(x => x.KlinikID == id).ToList();
            TempData["KlinikID"] = id;
            return View(cc);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonelEkle(Personel p)
        {
            p.KlinikID = (int)TempData["KlinikID"];
            c.Personels.Add(p);
            c.SaveChanges();
            Giris cc = new Giris();
            string username = (p.PersonelAdı + p.PersonelSoyadı);
            cc.Username = username;

            // Hashing the password
            string hashedPassword = b.HashPassword("1234");
            cc.Password = hashedPassword;

            cc.PersonelID = p.PersonelID;
            c.Girises.Add(cc);
            c.SaveChanges();
            return RedirectToAction("Index", "Personel", new { id = p.KlinikID });
        }
    }
}
