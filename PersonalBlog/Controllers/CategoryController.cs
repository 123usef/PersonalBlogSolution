using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Context;

namespace PersonalBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context; 

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;    
        }
        public IActionResult Index()
        {
            var cats = _context.categories.ToList();


            return View(cats);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
