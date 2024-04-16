using HastaneOtomasyonu.DataAccessLayer;
using HastaneOtomasyonu.EntityLayer.Models.Entity;
using HastaneOtomasyonu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HastaneOtomasyonu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        public IActionResult Index()
        {
            var cc = c.Polikliniks.ToList();
            return View(cc);
        }

        [HttpGet]
        public IActionResult PolinikEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PolinikEkle(Poliklinik p)
        {
            c.Polikliniks.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
