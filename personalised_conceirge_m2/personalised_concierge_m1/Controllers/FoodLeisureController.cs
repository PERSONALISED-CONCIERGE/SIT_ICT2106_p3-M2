using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personalised_concierge_m1.Controllers
{
    public class FoodLeisureController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SpecificFoodLeisure(string FoodLeisureID)
        {
            if(FoodLeisureID != null)
            {
                return View();
            }
            return Content(FoodLeisureID);
        }
    }
}
