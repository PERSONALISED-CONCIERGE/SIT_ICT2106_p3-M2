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
using personalised_concierge_m1.Modelspersonalised_concierge_m1.Models;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Controllers
{
    public class CalendarEventController : Controller
    {
        private CalendarEvent calendarEvent = new CalendarEvent();
        private readonly IM2UnitOfWork _m2UnitOfWork;
        private static int currentCalendarId;

        public CalendarEventController(IM2UnitOfWork m2UnitOfWork)
        {
            _m2UnitOfWork = m2UnitOfWork;
        }

        public IActionResult Index()
        {
            calendarEvent = getAllCalendarEvent();
            return View(calendarEvent);
        }

        public CalendarEvent getAllCalendarEvent()
        {
            var calendarEventList = _m2UnitOfWork.CalendarEventDetails.getAllEventById(currentCalendarId);
            //datetime is in this format after retrieve from db: 8/3/2022 12:00:00 am
            calendarEvent.CalendarEventList = calendarEventList;
            return calendarEvent;
        }

        [HttpPost]
        public JsonResult createEvent(int id, string name, string type, string location, string description, string date, string startTime, string endTime, string note, int otherId)
        {
            if (id == 0) // adding new entry to calendarEvent table 
            {
                ICalendarEvent calendarEvent1 = CalendarEventFactory.makeCalendarEvent(type, otherId);
                CalendarEvent calendarEvent = calendarEvent1.createCalendarEventObj(name, location, type, description, date, startTime, endTime, note);
                calendarEvent.CalendarId = currentCalendarId;
                //CalendarEvent calendarEvent = setCalendarEventObject(name, location, type, description, date, startTime, endTime, note, otherId);
                _m2UnitOfWork.CalendarEventDetails.addEvent(calendarEvent);
                string jsonString = JsonConvert.SerializeObject(calendarEvent);
                return new JsonResult(jsonString);
            }
            else // updating calendarEvent with id specified
            {
                ICalendarEvent calendarEvent1 = CalendarEventFactory.makeCalendarEvent(type, otherId);
                CalendarEvent calendarEvent = calendarEvent1.updateCalendarEventObj(id, name, type, location, description, date, startTime, endTime, note);
                calendarEvent.CalendarId = currentCalendarId;
                //CalendarEvent calendarEvent = setCalendarEventObjectWithId(id, name, type, location, description, date, startTime, endTime, note, otherId);
                _m2UnitOfWork.CalendarEventDetails.updateEvent(calendarEvent);
                string jsonString = JsonConvert.SerializeObject(calendarEvent);
                return new JsonResult(jsonString);
            }

        }

        [HttpPost]
        public JsonResult retrieveEvent(int eventId)
        {
            var calendarEvent = _m2UnitOfWork.CalendarEventDetails.getEventByEventId(currentCalendarId, eventId);
            string jsonString = JsonConvert.SerializeObject(calendarEvent);
            return new JsonResult(jsonString);
        }

        public JsonResult deleteEvent(int eventId)
        {
            _m2UnitOfWork.CalendarEventDetails.deleteEvent(currentCalendarId, eventId);
            string jsonString = JsonConvert.SerializeObject(calendarEvent);
            return new JsonResult(jsonString);
        }

        public JsonResult retrieveAttraction(int id)
        {
            var attraction = _m2UnitOfWork.AttractionDemoDetails.findAttractionById(id);
            string jsonString = JsonConvert.SerializeObject(attraction);
            return new JsonResult(jsonString);
        }

        public JsonResult getInitialDate()
        {
            var calendarObj = _m2UnitOfWork.CalendarEventDetails.getCalendarDetails(currentCalendarId);
            string jsonString = JsonConvert.SerializeObject(calendarObj);
            return new JsonResult(jsonString);
        }

        public JsonResult postId(int id)
        {
            currentCalendarId = id;
            string jsonString = JsonConvert.SerializeObject(calendarEvent);
            return new JsonResult(jsonString);
        }
    }
}
