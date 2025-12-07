using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Context;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }
        // all posts 
        public IActionResult Index()
        {
            var posts = _context.posts.ToList();
            return View(posts);
        }

        // get one post by id 
        public IActionResult GetById(int id)
        {
            // make operations database transactions 
            return View();
        }

        public IActionResult CreatePost(Post pst)
        {
            // make operations database transactions 
            return View();
        }

    }
}
