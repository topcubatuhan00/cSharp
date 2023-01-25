using AspNetCoreIntro.Entities;
using AspNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreIntro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index3()
        {
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
        public string SaveCustomer(Customer customer)
        {

            return "kaydedildi";

        }
    }
}
