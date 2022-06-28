using Microsoft.AspNetCore.Mvc;

namespace myapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public class GalleryController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
    }
    public class loginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
    public class entryController : Controller
    {
        public IActionResult entry()
        {
            return View();
        }
    }

}
