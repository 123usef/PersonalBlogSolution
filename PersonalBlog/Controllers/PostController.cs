using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    public class PostController : Controller
    {
        // all posts 
        public IActionResult Index()
        {
            return View();
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
