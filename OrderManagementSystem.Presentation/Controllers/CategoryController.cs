using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
