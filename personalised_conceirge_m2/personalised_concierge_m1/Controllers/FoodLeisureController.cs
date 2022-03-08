using System;
using System.Dynamic;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;


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
            dynamic mymodel = new ExpandoObject();
            mymodel.restaurants = _m2UnitOfWork.FoodLeisureDetails.GetLimitedFoodLeisureBytype(FoodLeisureType.Restaurant);
            mymodel.pois = _m2UnitOfWork.FoodLeisureDetails.GetLimitedFoodLeisureBytype(FoodLeisureType.POI);
            mymodel.hawkers = _m2UnitOfWork.FoodLeisureDetails.GetLimitedFoodLeisureBytype(FoodLeisureType.Hawker);

            mymodel.featuredFoodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetAll();

            // Create the empty list of objects to store the featured foodleisure items
            List<FoodLeisure> featuredFoodLeisure = new List<FoodLeisure>();

            //! Check for the number of properties in the object
            // Type type = typeof(YourClassName);
            // int NumberOfRecords = type.GetProperties().Length;

            //! Loop through the dynamic model and add the object that has featured == true to the list
            foreach (var item in mymodel.featuredFoodLeisure)
            {
                if (item.featured == true)
                {
                    featuredFoodLeisure.Add(item);
                }
            }
            mymodel.featuredFoodLeisure = featuredFoodLeisure;


            return View(mymodel);
        }

       

        [HttpPost]
        public IActionResult SpecificFoodLeisure(int FoodLeisureID)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.foodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(FoodLeisureID);
            mymodel.reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
            mymodel.accounts = _unitOfWork.AccountDetails.GetAll();
            string review = Request.Form["Review_Description"];

            //Get sum of all ratings
            double totalratings = 0;
            double avgrating = 0.0;
            var count = 0;
            foreach (Review areview in mymodel.reviews)
            {

                count++;
                int ratingInt = (int)(Rating)Enum.Parse(typeof(Rating), areview.rating.ToString());
                totalratings += ratingInt;
                avgrating = Math.Round(totalratings / count, 3);
            }


            //display even if there is no submision from review form 
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

                // if cannot submit review 
                if (!result)
                {
                    return NotFound();
                }
                else
                {
                    // all these for display after submit 
                    mymodel.reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);

                    //count rating again on refresh ah!
                    totalratings = 0;
                    avgrating = 0.0;
                    count = 0;
                    foreach (Review areview in mymodel.reviews)
                    {
                        count++;
                        int ratingInt = (int)(Rating)Enum.Parse(typeof(Rating), areview.rating.ToString());
                        totalratings += ratingInt;
                        avgrating = Math.Round(totalratings / count, 3);

                        mymodel.totalrating = totalratings;
                        mymodel.avgrating = avgrating;
                    }



                    mymodel.totalrating = totalratings;
                    mymodel.avgrating = avgrating;
                    return View(mymodel);
                }
            }

            mymodel.totalrating = totalratings;
            mymodel.avgrating = avgrating;
            return View(mymodel);
        }
    }
}
