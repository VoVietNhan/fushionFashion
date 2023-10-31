using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
		public IActionResult Details()
		{
			return View();
		}
        public IActionResult Home()
        {
            return View();
        }
    }
}
