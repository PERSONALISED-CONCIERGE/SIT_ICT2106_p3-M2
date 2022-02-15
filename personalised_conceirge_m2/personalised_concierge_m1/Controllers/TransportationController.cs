using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personalised_concierge_m1.Controllers
{
    public class TransportationController : Controller
    {
        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IM2UnitOfWork _m2UnitOfWork;

        public TransportationController(IM2UnitOfWork m2UnitOfWork)
        {
            this._m2UnitOfWork = m2UnitOfWork;
        }

        // GET: /<controller>/
        public IActionResult ViewTransportation()
        {
            //variable getting data from DB and storing in an Object 
            var transportList = _m2UnitOfWork.TransportationDetails.GetAll();
            var taxifaresList = _m2UnitOfWork.TransportFareDetails.GetAll();



            ViewData["transports"] = transportList;
            ViewData["taxifares"] = taxifaresList;
            return View();
        }
    }
}
