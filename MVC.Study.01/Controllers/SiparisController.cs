using Microsoft.AspNetCore.Mvc;
using MVC.Study._01.Context.Concrete;
using MVC.Study._01.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC.Study._01.Controllers
{
    public class SiparisController : Controller
    {
        private readonly MyDBContext _dbContext;
        public SiparisController(MyDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var siparisler = _dbContext.Siparisler.Include(s=>s.Musteri).Include(s=>s.Urun).ToList();
            return View(siparisler);
        }


        public IActionResult Create()
        {
            ViewBag.UrunId = new SelectList(_dbContext.Urunler, "UrunId", "UrunAdi");
            ViewBag.Musteri = new SelectList(_dbContext.Musteriler, "MusteriId", "Ad");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Siparis siparis)
        {
            _dbContext.Add(siparis);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var siparis = _dbContext.Siparisler.Find(id);

            ViewBag.MusteriId = new SelectList(_dbContext.Musteriler, "MusteriId", "Ad", siparis.MusteriId);
            ViewBag.UrunId = new SelectList(_dbContext.Urunler, "UrunId", "UrunAdi", siparis.UrunId);
            return View(siparis);
        }

        [HttpPost]
        public IActionResult Edit(Siparis siparis)
        {
            _dbContext.Update(siparis);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Siparis siparis = _dbContext.Siparisler.Where(i => i.SiparisId == id).SingleOrDefault();

            _dbContext.Remove(siparis);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}