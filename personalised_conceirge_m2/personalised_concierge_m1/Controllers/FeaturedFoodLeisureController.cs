using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using personalised_concierge_m1.Data;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Models.Entities.OtherServices;
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
            mymodel.myLeisure = _m2UnitOfWork.FoodLeisureDetails.GetAll();

            return View(mymodel);
        }

        [HttpPost]
        public IActionResult Edit(int FoodLeisureID, bool featured)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.foodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(FoodLeisureID);


            FoodLeisure newfoodLeisure = new FoodLeisure();
            newfoodLeisure.foodleisure_id = FoodLeisureID;
            newfoodLeisure.featured = featured;
            _m2UnitOfWork.FoodLeisureDetails.UpdateFeatured(newfoodLeisure);

            /* var result = db.Students.SingleOrDefault(b => b.StudentId == 6);
            if (result != null)
            {
                result.StudentName = "Changed";
                db.SaveChanges();
            }*/

            var result = _m2UnitOfWork.FoodLeisureDetails.SingleOrDefault();
            if (result != null)
            {
                result.featured = "Changed";
                db.SaveChanges();
            }    

            return View(mymodel);
        }

        /*public IActionResult Edit (FoodLeisure foodLeisure)
        {
            var f = "None";
            if (foodLeisure.featured == true)
                f = "True";
            else
                f = "False";

            FoodLeisure food = new FoodLeisure();
            food.featured = f;
            _m2UnitOfWork.FoodLeisureDetails.InsertOnSubmit(food);
            _m2UnitOfWork.FoodLeisureDetails.SubmitChanges();
            return View();
        }*/

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int FoodLeisureID)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.foodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(FoodLeisureID);

            var f = "None";
            if (foodLeisure.featured == true)
            {
                f = "true";
            }
            else
            {
                f = "false";
            }

            FoodLeisure fl = new FoodLeisure();
            fl.featured = f;
            mymodel.FoodLeisure.InsertOnSubmit();
            mymodel.SubmitChanges();
            return View();
        }*/

        /*[HttpPost]
        public IActionResult Edit(int FoodLeisureID, FoodLeisure foodLeisure)
        //public IActionResult Edit([Bind("foodleisure_id, name, description, website_link, contact_num, type, address")] FoodLeisure foodLeisure)
        {
            if (ModelState.IsValid)
            {
                dynamic mymodel = new ExpandoObject();
                mymodel.myLeisure.Update(foodLeisure);
                mymodel.SaveChanges();
                return RedirectToAction("Admin_AddFeaturedFoodLeisure");
            }
            return View();
        }*/
       

        /*public IActionResult Create(FoodLeisure foodLeisure)
        {
            try
            {
                using (dynamic dbModel = new ExpandoObject())
                {
                    dbModel.myLeisure.Add(foodLeisure);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Admin_AddFeaturedFoodLeisure");
            }
            catch
            {
                return View();
            }
        }*/

            /*
            public IActionResult Edit(int FoodLeisureID)
            {
                dynamic mymodel = new ExpandoObject();
                mymodel.foodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(FoodLeisureID);
                {
                    return View(mymodel);
                }   
            }

            [HttpPost]
            //public IActionResult Edit(int FoodLeisureID, FoodLeisure foodLeisure)
            public IActionResult Edit([Bind("foodleisure_id, name, description, website_link, contact_num, type, address")] FoodLeisure foodLeisure)
            {
                if (ModelState.IsValid)
                {
                    dynamic mymodel = new ExpandoObject();
                    mymodel.myLeisure.Update(foodLeisure);
                    mymodel.SaveChanges();
                    return RedirectToAction("Admin_AddFeaturedFoodLeisure");
                }
                return View(foodLeisure);
                /*try
                {
                    dynamic mymodel = new ExpandoObject();
                    mymodel.foodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(FoodLeisureID);
                    {
                        mymodel.Entry(foodLeisure).State = EntityState.Modified;
                        mymodel.SaveChanges();
                    }
                    return RedirectToAction("Admin_AddFeaturedFoodLeisure");
                }
                catch
                {
                    return View();
                }
            }*/

            /*public IActionResult Edit (int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var myLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(1);
                if (myLeisure == null)
                {
                    return NotFound();
                }
                return View(myLeisure);
            }*/

            /*[HttpPost]
            public IActionResult Edit (int id, [Bind("foodleisure_id, name, description, website_link, contact_num, type, address")] MyLeisure myLeisure)
            {
                if (ModelState.IsValid)
                {
                    _m2UnitOfWork.Update(myLeisure);
                    _m2UnitOfWork.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }*/
        }
    }