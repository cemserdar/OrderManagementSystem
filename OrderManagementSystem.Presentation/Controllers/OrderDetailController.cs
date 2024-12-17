using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Presentation.Controllers
{
    public class OrderDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
