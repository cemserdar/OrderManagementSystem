using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Presentation.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
