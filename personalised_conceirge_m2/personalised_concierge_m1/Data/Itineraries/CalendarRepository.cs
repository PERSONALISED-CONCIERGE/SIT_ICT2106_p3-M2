using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using personalised_concierge_m1.Data;
using personalised_concierge_m1.Interface;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Repository
{
    public class CalendarRepository : GenericRepo<Calendar>, ICalendarRepository
    {
        private readonly ConciergeContext _context;

        public CalendarRepository(ConciergeContext context) : base(context)
        {
            _context = context;
        }

        public void addCalendar(Calendar calendar)
        {
            _context.Add(calendar);
            _context.SaveChanges();
        }

        public List<Calendar> getAllCalendar()
        {
            var itineraryList = _context.calendar.ToList();
            return itineraryList;
        }

        public void deleteCalendar(int calendarId)
        {
            var calendarObj = _context.calendar.Where(m => m.CalendarId == calendarId).FirstOrDefault();
            _context.calendar.Remove(calendarObj);
            _context.SaveChanges();
        }
    }
}