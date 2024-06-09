using Microsoft.AspNetCore.Mvc;

namespace ASP_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            bool isLoggedIn = false; 

            if (!isLoggedIn)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
