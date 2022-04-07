using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Modelspersonalised_concierge_m1.Models;

namespace personalised_concierge_m1.Models
{
    public class CustomEvent : ICalendarEvent
    {
        private CalendarEvent calendarEvent;
        private int defaultId = 0;
        public CustomEvent()
        {
            calendarEvent = new CalendarEvent();
        }

        public CalendarEvent createCalendarEventObj(string name, string location, string type, string description, string date, string startTime, string endTime, string note)
        {
            DateTime startDateTime = convertStringToDateTime(date + " " + startTime);
            DateTime endDateTime = convertStringToDateTime(date + " " + endTime);
            calendarEvent.Type = type;
            calendarEvent.Name = name;
            calendarEvent.Location = location;
            calendarEvent.Description = description;
            calendarEvent.Date = Convert.ToDateTime(date);
            calendarEvent.StartTime = startDateTime;
            calendarEvent.EndTime = endDateTime;
            calendarEvent.Note = note;
            calendarEvent.OtherId = defaultId;
            return calendarEvent;
        }

        public CalendarEvent updateCalendarEventObj(int id, string name, string type, string location, string description, string date, string startTime, string endTime, string note)
        {
            DateTime startDateTime = convertStringToDateTime(date + " " + startTime);
            DateTime endDateTime = convertStringToDateTime(date + " " + endTime);
            calendarEvent.CalendarEventId = id;
            calendarEvent.Type = type;
            calendarEvent.Name = name;
            calendarEvent.Location = location;
            calendarEvent.Description = description;
            calendarEvent.Date = Convert.ToDateTime(date);
            calendarEvent.StartTime = startDateTime;
            calendarEvent.EndTime = endDateTime;
            calendarEvent.Note = note;
            calendarEvent.OtherId = defaultId;
            return calendarEvent;
        }

        // convert string of e.g "05/01/2009 06:32:00" to DateTime
        private DateTime convertStringToDateTime(string dateTime)
        {
            DateTime dateValue;
            DateTime.TryParse(dateTime, out dateValue);
            return dateValue;
        }
    }
}