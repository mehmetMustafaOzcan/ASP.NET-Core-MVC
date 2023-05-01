using marketDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace marketDb.Controllers
{
    public class AnimalController : Controller
    {
        private readonly UrunContext _context;

        public AnimalController(UrunContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
        
            return View(_context.Animals);
        }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Animal animal,IFormFile Image)
        {
            ImageSet(animal, Image);
            _context.Animals.Add(animal);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private void ImageSet(Animal animal, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null && Image.Length != 0)
                {
                    var filename = Path.GetFileName(Image.FileName);
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", filename);
                    using (var fs = new FileStream(filepath, FileMode.Create))
                    {
                        Image.CopyTo(fs);
                    }
                    animal.Photopath = "/img/" + filename;
                }
            }
        }

        public IActionResult Edit(int id)
        {
            var urun = _context.Animals.Find(id);


            return View(urun);
        }
        [HttpPost]
        public IActionResult Edit(Animal animal, IFormFile Photopath)
        {
            ImageSet(animal, Photopath);
           _context.Animals.Update(animal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var animal = _context.Animals.Find(id);
            
            _context.Remove(animal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
