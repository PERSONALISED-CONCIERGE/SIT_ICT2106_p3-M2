
using Microsoft.AspNetCore.Mvc;

using personalised_concierge_m1.Models.Interfaces;
using System.Dynamic;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using System.Collections.Generic;

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
            mymodel.allLeisure = _m2UnitOfWork.FoodLeisureDetails.GetFeaturedFoodLeisure(false);
            var allLeisure2 = _m2UnitOfWork.FoodLeisureDetails.GetFeaturedFoodLeisure(false);
            List<string> FoodLesiureName = new List<string>();
            foreach (FoodLeisure foodleisure in allLeisure2)
            {
                FoodLesiureName.Add(foodleisure.name);
            }

            mymodel.nameList = FoodLesiureName;
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult Edit(int FoodLeisureID, bool featured, string FoodLeisureName )
        {

            
            if(FoodLeisureName == null)
            {
                FoodLeisure newfoodLeisure = new FoodLeisure();
                newfoodLeisure.foodleisure_id = FoodLeisureID;
                newfoodLeisure.featured = featured;
                _m2UnitOfWork.FoodLeisureDetails.UpdateFeatured(newfoodLeisure);
            }
            else
            {
         
                FoodLeisure foodLeisureItem = _m2UnitOfWork.FoodLeisureDetails.GetFoodLeisureByName(FoodLeisureName);
                foodLeisureItem.featured = featured;
                _m2UnitOfWork.FoodLeisureDetails.UpdateFeatured(foodLeisureItem);
            }

            return RedirectToAction("Admin_AddFeaturedFoodLeisure", "FeaturedFoodLeisure");
        }

       
        }
    }