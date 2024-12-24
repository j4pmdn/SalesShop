using Microsoft.AspNetCore.Mvc;

namespace SalesShop.Controllers
{
    public class CategoryController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
