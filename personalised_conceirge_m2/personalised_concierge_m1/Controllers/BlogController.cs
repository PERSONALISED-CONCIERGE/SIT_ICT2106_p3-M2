using System;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Controllers
{
    public class BlogController : Controller
    {
        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IM2UnitOfWork _m2UnitOfWork;
        private readonly IUnitOfWork _unitOfWork;

        public BlogController(IM2UnitOfWork m2UnitOfWork, IUnitOfWork m1UnitOfWork)
        {
            this._m2UnitOfWork = m2UnitOfWork;
            this._unitOfWork = m1UnitOfWork;

        }

        [HttpGet]
        public IActionResult BlogList()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.myBlog = _m2UnitOfWork.BlogDetails.GetAll();
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult Blog(int itinerary_id)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.myItineraryItem = _m2UnitOfWork.ItineraryItemDetails.GetByItineraryID(itinerary_id);
            mymodel.myFoodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetAll();
            mymodel.myBlog = _m2UnitOfWork.BlogDetails.GetAll();
            return View(mymodel);
        }

    }
}