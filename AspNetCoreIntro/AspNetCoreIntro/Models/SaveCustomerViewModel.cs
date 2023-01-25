using AspNetCoreIntro.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreIntro.Models
{
    public class SaveCustomerViewModel
    {
        public Customer customer { get; set; }
        public List<SelectListItem> cities { get; set; }
    }
}
