using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Models
{
    public class Calendar
    {
        [Column("CalendarId")]
        [Key]
        private int calendarId;

        [Column("CreatedDate")]
        private DateTime createdDate;

        [Column("StartDate")]
        private DateTime startDate;

        [Column("EndDate")]
        private DateTime endDate;

        [NotMapped]
        private List<Calendar> calendarList;
        public int CalendarId
        {
            get { return calendarId; }
            set { calendarId = value; }
        }
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        public DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }
        public DateTime EndDate
        {
            set { endDate = value; }
            get { return endDate; }
        }
        [NotMapped]
        public List<Calendar> CalendarList
        {
            set { calendarList = value; }
            get { return calendarList; }
        }
        public void createItinerary(DateTime createdDate, DateTime startDate, DateTime endDate)
        {
            CreatedDate = createdDate;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}