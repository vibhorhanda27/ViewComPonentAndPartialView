using DNT390_ViewComPonentPartialViewLab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNT390_ViewComPonentPartialViewLab2.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel postViewModel = new PostViewModel()
            {
                Id = 1,
                Title = "What is ASP.NET Core",
                Author = "Shailendra Chauhan",
                Body = "ASP.NET Core is an open-source framework for building UI and API..."
            };
            
           
            return View(postViewModel);
        }
    }
}
