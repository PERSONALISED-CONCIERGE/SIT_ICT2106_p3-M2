using System;
using System.Collections.Generic;
using System.Text;
using personalised_concierge_m1.Modelspersonalised_concierge_m1.Models;

namespace personalised_concierge_m1.Models
{
    class CalendarEventFactory
    {
        //private CalendarEventFactory myProduct;
        public CalendarEventFactory() { }
        public static ICalendarEvent makeCalendarEvent(string type, int id)
        {
            if (type == "custom")
            {
                return new CustomEvent();
            }
            else if(type == "attraction")
            {
                return new AttractionEvent(id);
            }
            return null;
        }
    }


}
