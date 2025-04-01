using Microsoft.AspNetCore.Mvc;

namespace Bai6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
} 