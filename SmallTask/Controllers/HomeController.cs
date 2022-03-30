using Microsoft.AspNetCore.Mvc;

namespace SmallTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if(name != null)
            {
                ViewData["Message"] = "Hi, " + name;
                return View("HiName");
            }
            return View();
        }
    }
}
