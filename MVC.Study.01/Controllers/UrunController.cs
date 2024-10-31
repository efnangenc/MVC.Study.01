using Microsoft.AspNetCore.Mvc;
using MVC.Study._01.Context.Concrete;
using MVC.Study._01.Context;

namespace MVC.Study._01.Controllers
{
    public class UrunController : Controller
    {
        private readonly MyDBContext _dbContext;
        public UrunController(MyDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var urunler = _dbContext.Urunler.ToList();
            return View(urunler);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Urun urun)
        {
            _dbContext.Urunler.Add(urun);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Urun urun= _dbContext.Urunler.Find(id);

            return View(urun);
        }
        [HttpPost]
        public IActionResult Update(Urun urun)
        {
            _dbContext.Update(urun);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Urun urun = _dbContext.Urunler.Where(i => i.UrunId == id).SingleOrDefault();

            _dbContext.Remove(urun);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
