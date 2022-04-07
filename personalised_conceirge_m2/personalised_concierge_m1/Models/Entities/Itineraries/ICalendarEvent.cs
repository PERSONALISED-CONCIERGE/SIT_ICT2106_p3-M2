using System;
using System.Collections.Generic;
using System.Text;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Modelspersonalised_concierge_m1.Models
{
    interface ICalendarEvent
    {
        public CalendarEvent createCalendarEventObj(string name, string location, string type, string description, string date, string startTime, string endTime, string note);

        public CalendarEvent updateCalendarEventObj(int id, string name, string type, string location, string description, string date, string startTime, string endTime, string note);
    }
}