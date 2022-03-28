using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Entities.Navigation;

namespace personalised_concierge_m1.Controllers
{
    public class NavigationController : Controller
    {
        private Navigation navigation = new Navigation();

        public IActionResult Index()
        {
            return View(navigation);
        }
    }
}
