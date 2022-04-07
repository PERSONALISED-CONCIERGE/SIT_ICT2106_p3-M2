using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using personalised_concierge_m1.Data;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Interface;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Controllers
{
    public class CalendarController : Controller
    {
        private Calendar calendar = new Calendar();
        private readonly IM2UnitOfWork _m2UnitOfWork;

        public CalendarController(IM2UnitOfWork m2UnitOfWork)
        {
            _m2UnitOfWork = m2UnitOfWork;

        }

        public IActionResult Index()
        {
            calendar.CalendarList = getAllCalendar();
            return View(calendar);
        }

        public List<Calendar> getAllCalendar()
        {
            return _m2UnitOfWork.CalendarDetails.getAllCalendar();
        }

        [HttpPost]
        public JsonResult createItinerary(string createdDate, string startDate, string endDate)
        {
            Calendar itinerary = new Calendar();
            itinerary.createItinerary(Convert.ToDateTime(createdDate), Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
            _m2UnitOfWork.CalendarDetails.addCalendar(itinerary);
            string itineraryObjString = JsonConvert.SerializeObject(itinerary);
            return new JsonResult(itineraryObjString);
        }

        [HttpPost]
        public JsonResult deleteCalendar(int id)
        {
            Calendar itinerary = new Calendar();
            _m2UnitOfWork.CalendarDetails.deleteCalendar(id);
            _m2UnitOfWork.CalendarEventDetails.cascadeDelete(id);
            string itineraryObjString = JsonConvert.SerializeObject(itinerary);
            return new JsonResult(itineraryObjString);
        }
    }
}
