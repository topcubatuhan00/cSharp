using AspNetCoreIntro.Entities;
using AspNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    // domain/product/index
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
