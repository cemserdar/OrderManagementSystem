using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Presentation.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
