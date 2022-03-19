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

namespace personalised_concierge_m1.Controllers
{
    public class HomeController : Controller
    {
        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IUnitOfWork _unitOfWork;
        private readonly IM2UnitOfWork _m2UnitOfWork;
        private readonly IM3UnitOfWork _m3UnitOfWork;


        public HomeController(IUnitOfWork unitOfWork, IM2UnitOfWork m2UnitOfWork, IM3UnitOfWork m3UnitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._m2UnitOfWork = m2UnitOfWork;
            this._m3UnitOfWork = m3UnitOfWork;
        }
        public IActionResult Index()
        {
            
            //variable getting data from DB and storing in an Object Example
            var myRoom = _unitOfWork.RoomDetails.GetById(1);
            var myReservation = _unitOfWork.ReservationDetails.GetById(1);
            var myAccount = _unitOfWork.AccountDetails.GetById(1);
            var myLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(1);
            var myEnum = _m2UnitOfWork.ReviewDetails.GetById(1);
            var myRequest = _m3UnitOfWork.RequestDetails.GetById(1);
            
            ViewData["myRoom"] = myRoom;
            ViewData["myAccount"] = myAccount;
            ViewData["myLeisure"] = myLeisure;
            ViewData["myenum"] = myEnum;
            ViewData["myrequest"] = myRequest;

            
            //data is return to the view to be used there.
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}