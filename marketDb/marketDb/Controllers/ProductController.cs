using marketDb.Models;
using Microsoft.AspNetCore.Mvc;

namespace marketDb.Controllers
{
    public class ProductController : Controller
    {
      private readonly UrunContext _context;

        public ProductController(UrunContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           
            return View(_context.Uruns.ToList());
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Urun urun)
        {
            _context.Add(urun);
            _context.SaveChanges();
            return View();
        }
        public IActionResult Edit(int id)
        {
            var urun = _context.Uruns.Find(id);

            return View(urun);
        }
        [HttpPost]
        public IActionResult Edit(Urun urun)
        {
            _context.Update(urun);
            _context.SaveChanges();
            return View();
        }
        
        public IActionResult Delete(int id)
        {
           var urun= _context.Uruns.Find(id);
            _context.Remove(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
