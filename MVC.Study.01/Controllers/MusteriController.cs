using Microsoft.AspNetCore.Mvc;
using MVC.Study._01.Context;
using MVC.Study._01.Context.Concrete;

namespace MVC.Study._01.Controllers
{
    public class MusteriController : Controller
    {
        private readonly MyDBContext _dbContext;
        public MusteriController(MyDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var musteriler = _dbContext.Musteriler.ToList();
            return View(musteriler);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Musteri musteri)
        {
            _dbContext.Musteriler.Add(musteri);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Musteri musteri = _dbContext.Musteriler.Find(id);
            
            return View(musteri);
        }
        [HttpPost]
        public IActionResult Update(Musteri musteri)
        {
            _dbContext.Update(musteri);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Musteri musteri = _dbContext.Musteriler.Where(i => i.MusteriId == id).SingleOrDefault();

            _dbContext.Remove(musteri);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
