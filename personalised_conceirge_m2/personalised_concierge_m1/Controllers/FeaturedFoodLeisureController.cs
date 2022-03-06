
using Microsoft.AspNetCore.Mvc;

using personalised_concierge_m1.Models.Interfaces;
using System.Dynamic;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Controllers
{
    public class FeaturedFoodLeisureController : Controller
    {
        private readonly IM2UnitOfWork _m2UnitOfWork;
        private readonly IUnitOfWork _unitOfWork;

        public FeaturedFoodLeisureController(IM2UnitOfWork m2UnitOfWork, IUnitOfWork m1UnitOfWork)
        {

            this._m2UnitOfWork = m2UnitOfWork;
            this._unitOfWork = m1UnitOfWork;
        }

        public IActionResult Admin_AddFeaturedFoodLeisure()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.myLeisure = _m2UnitOfWork.FoodLeisureDetails.GetFeaturedFoodLeisure(true);
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult Edit(int FoodLeisureID, bool featured)
        {



            FoodLeisure newfoodLeisure = new FoodLeisure();
            newfoodLeisure.foodleisure_id = FoodLeisureID;
            newfoodLeisure.featured = featured;
            _m2UnitOfWork.FoodLeisureDetails.UpdateFeatured(newfoodLeisure);






            return View();
        }

       
        }
    }