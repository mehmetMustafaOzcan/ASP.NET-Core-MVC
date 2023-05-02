using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCategory_Product_exercise.Models;

namespace MVCCategory_Product_exercise.Controllers
{
    public class ManageController : Controller
    {
        private readonly CompanyContext _context;

        public ManageController(CompanyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var uruns = _context.Categories.Include(x => x.Products).ToList();
            return View(uruns);
        }
        //------Category CRUD--------//
        public IActionResult ListCategories()
        {
            var uruns = _context.Categories;
            return View(uruns);

        }
        public IActionResult EditCategories(int id)
        {
            var cat = _context.Categories.Find(id);
            return View(cat);

        }
        [HttpPost]
        public IActionResult EditCategories(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("ListCategories");

        }
        public IActionResult DeleteCategory(int id)
        {
            _context.Remove(_context.Categories.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ListCategories");

        }
        public IActionResult CreateCategory()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("ListCategories");
        }

        //------Product Crud--------//
        public IActionResult ListProduct()
        {

            return View(_context.Products.Include(x => x.Category));

        }
        public IActionResult EditProduct(int id)
        {
            var prod = _context.Products.Find(id);
            return View(prod);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return RedirectToAction("ListProduct");

        }
        
        public IActionResult DeleteProduct(int id)
        {
            _context.Remove(_context.Products.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ListProduct");

        }
       
      
        public IActionResult CreateProduct()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            product.Category = _context.Categories.Find(product.CategoryId);
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("ListProduct");
            }
            return RedirectToAction("CreateProduct");

        }

    }
}
