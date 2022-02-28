using System;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Entities.OtherServices;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personalised_concierge_m1.Controllers
{
    public class FoodLeisureController : Controller
    {
        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IM2UnitOfWork _m2UnitOfWork;
        private readonly IUnitOfWork _unitOfWork;


        public FoodLeisureController(IM2UnitOfWork m2UnitOfWork, IUnitOfWork m1UnitOfWork)
        {

            this._m2UnitOfWork = m2UnitOfWork;
            this._unitOfWork = m1UnitOfWork;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult featuredFoodLeisure()
        {
            return View();
        }




        [HttpPost]
        public IActionResult SpecificFoodLeisure(int FoodLeisureID)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.foodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(FoodLeisureID);
            mymodel.reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
            mymodel.accounts = _unitOfWork.AccountDetails.GetAll();
            string review = Request.Form["Review_Description"];
            //remove 
            if (review != null)
            {

                string foodleisureID = Request.Form["foodLeisureID"];
                string ratings = Request.Form["Ratings"];
                var dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
                Review newReview = new Review();
                newReview.review = review;
                newReview.rating = (Rating)Enum.Parse(typeof(Rating), ratings, true);
                newReview.account_id = 1;
                newReview.foodleisure_id = Int32.Parse(foodleisureID);
                newReview.Date = dateAsString;
                _m2UnitOfWork.ReviewDetails.Add(newReview);
                Boolean result = _m2UnitOfWork.ReviewDetails.Save();

                if (!result)
                {
                    return NotFound();
                }
                else
                {
                    mymodel.reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
                    return View(mymodel);
                }
            }
            return View(mymodel);
        }






    }
}
