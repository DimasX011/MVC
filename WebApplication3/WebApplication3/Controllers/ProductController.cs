using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        private static ProductsCatalog _catalog = new();

        [HttpGet]
        public IActionResult Products()
        {
            return View(_catalog);
        }

        [HttpPost]
        public IActionResult Products([FromForm]ProductModel type)
        {
            _catalog.GetProducts.Add(type);
            return View(_catalog);
        }
    }
}
