using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        public static ProductsCatalog _catalog = new();

        [HttpGet]
        public IActionResult Products()
        {
            return View(_catalog);
        }


        [HttpPost]
        public IActionResult Products([FromForm]ProductModel exemp)
        {
            _catalog.GetProducts.Add(exemp);
            return View(_catalog);
        }
    }
}
