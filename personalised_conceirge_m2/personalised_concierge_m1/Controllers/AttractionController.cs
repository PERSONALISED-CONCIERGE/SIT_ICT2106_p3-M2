using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Entities.Attraction;

namespace personalised_concierge_m1.Controllers
{
    public class AtttractionController : Controller
    {
        private Atttraction attraction = new Attraction();

        public IActionResult Index()
        {
            return View(attraction);
        }
    }
}
