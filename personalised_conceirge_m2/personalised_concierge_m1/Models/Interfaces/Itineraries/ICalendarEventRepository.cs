using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Interface
{
    public interface ICalendarEventRepository : IGenericRepo<CalendarEvent>
    {
        void addEvent(CalendarEvent calendarEvent);

        List<CalendarEvent> getAllEventById(int id);

        CalendarEvent getEventByEventId(int currentCalendarId, int eventId);

        void updateEvent(CalendarEvent calendarEvent);

        void deleteEvent(int calendarId, int eventId);

        void cascadeDelete(int calendarId);

        Calendar getCalendarDetails(int calendarId);
    }
}