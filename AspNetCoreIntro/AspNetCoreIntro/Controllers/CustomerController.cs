using AspNetCoreIntro.Entities;
using AspNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCoreIntro.Services.Logging;

namespace AspNetCoreIntro.Controllers
{

    [Route("deneme")]
    public class CustomerController : Controller
    {

        private Services.Logging.ILogger _logger;

        public CustomerController(Services.Logging.ILogger logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            return View();
        }
         
        [Route("index")]
        [Route("")]
        public IActionResult Index3()
        {
            _logger.Logla("");
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,Name="batuhan",City="bursa"},
                new Customer{Id=2,Name="ahmet",City="tekirdag"},
                new Customer{Id=3,Name="yusuf",City="erzurum"}
            };
            List<string> shops = new List<string> { "ankara", "istanbul", "izmir" };


            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };

            return View(model);
        }

        [HttpGet]
        [Route("save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                cities = new List<SelectListItem> {
                    new SelectListItem { Text = "Ankara", Value = "06" },
                    new SelectListItem { Text = "İstanbul", Value = "34" },
                    new SelectListItem { Text = "Bursa", Value = "16" },
                    new SelectListItem { Text = "Ardahan", Value = "75" },
                    new SelectListItem { Text = "Erzurum", Value = "25" },
                } 
            
            
            });
        }

        [HttpPost]
        [Route("save")]
        public string SaveCustomer(Customer customer)
        {

            return "kaydedildi";

        }
    }
}
