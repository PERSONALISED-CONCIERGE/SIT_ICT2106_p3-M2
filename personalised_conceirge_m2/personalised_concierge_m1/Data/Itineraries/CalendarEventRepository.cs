using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using personalised_concierge_m1.Data;
using personalised_concierge_m1.Interface;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Repository
{
    public class CalendarEventRepository : GenericRepo<CalendarEvent>, ICalendarEventRepository
    {
        private readonly ConciergeContext _context;

        public CalendarEventRepository(ConciergeContext context) : base(context)
        {
            _context = context;
        }

        public void addEvent(CalendarEvent calendarEvent)
        {
            _context.Add(calendarEvent);
            _context.SaveChanges();
        }

        public List<CalendarEvent> getAllEventById(int id)
        {
            //format of dateTime: 2022-01-18T07:00:00+08:00
            var calendarEventList = _context.calendarEvent.Where(m => m.CalendarId == id).ToList();
            return calendarEventList;
        }

        public CalendarEvent getEventByEventId(int currentCalendarId, int eventId)
        {
            var calendarEvent = _context.calendarEvent.Where(m => m.CalendarId == currentCalendarId && m.CalendarEventId == eventId).FirstOrDefault();
            return calendarEvent;
        }

        public void updateEvent(CalendarEvent calendarEvent)
        {
            CalendarEvent cEvent = _context.calendarEvent.Where(p => p.CalendarEventId == calendarEvent.CalendarEventId).FirstOrDefault();
            if (cEvent != null)
            {
                _context.Entry(cEvent).CurrentValues.SetValues(calendarEvent);
                _context.SaveChanges();
            }
        }

        public void deleteEvent(int calendarid, int eventId)
        {
            var calendarEvent = _context.calendarEvent.Where(m => m.CalendarEventId == eventId && m.CalendarId == calendarid).FirstOrDefault();
            _context.calendarEvent.Remove(calendarEvent);
            _context.SaveChanges();
        }

        public void cascadeDelete(int calendarId)
        {
            _context.calendarEvent.RemoveRange(_context.calendarEvent.Where(m => m.CalendarId == calendarId));
            _context.SaveChanges();
        }

        public Calendar getCalendarDetails(int calendarId)
        {
            var calendarObj = _context.calendar.Where(m => m.CalendarId == calendarId).FirstOrDefault();
            return calendarObj;
        }
    }
}