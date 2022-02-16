using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Entities.OtherServices;

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

        // GET: /<controller>/
        public IActionResult AddTransportation()
        {

            var transportList = _m2UnitOfWork.TransportationDetails.GetAll();

            ViewData["transports"] = transportList;


            return View();
        }
        // GET: /<controller>/
        public IActionResult EditTransportation()
        {

            return View();
        }

        [HttpPost]
        public ActionResult addcompany(string company, string description, int phonenum, string website)
        {
            //variable getting data from DB and storing in an Object 
            var transportList = _m2UnitOfWork.TransportationDetails.GetAll();
            ViewData["transports"] = transportList;
            if (company!= null)
            {
                var transport = new Models.Entities.OtherServices.Transportation();
                transport.account_id = 1;
                transport.company_name = company;
                transport.description = description;
                transport.contact_num = phonenum;
                transport.website = website;
             
                    _m2UnitOfWork.TransportationDetails.Add(transport);
                    _m2UnitOfWork.TransportationDetails.Save();
                    ViewBag.status = true;
                    return View("AddTransportation");
                
               
            }
            else {
                ViewBag.status = false;
            }
            return View("AddTransportation");
        }
        [HttpPost]
        public ActionResult addfare(string transportID, string taxitype, string faretype, string fare)
        {
            var transportList = _m2UnitOfWork.TransportationDetails.GetAll();

            ViewData["transports"] = transportList;

            var id = int.Parse(transportID);
            if ( faretype != null)
            {
                var transportfare = new Models.Entities.OtherServices.TransportFares();
                transportfare.transport_id = id;
                if( faretype == "Standard")
                {
                    transportfare.type = TaxiType.Standard;
                }
                else if (faretype == "Limo")
                {
                    transportfare.type = TaxiType.Limo;
                }
                else if (faretype == "Chrylsler")
                {
                    transportfare.type = TaxiType.Chrylsler;
                }
                transportfare.fare_name = faretype;
                transportfare.fares = fare;
                _m2UnitOfWork.TransportFareDetails.Add(transportfare);
                _m2UnitOfWork.TransportationDetails.Save();
                ViewBag.status = true;
                return View("AddTransportation");

            }

            else
            {
                ViewBag.status = false;
            }
            return View("AddTransportation");
        }

    }
}
