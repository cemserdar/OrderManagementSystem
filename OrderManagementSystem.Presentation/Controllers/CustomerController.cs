using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Presentation.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
