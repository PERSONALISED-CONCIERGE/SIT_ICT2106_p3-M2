using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Models
{
    public class CalendarEvent
    {
        [Column("CalendarEventId")]
        [Key]
        private int calendarEventId;

        [Column("CalendarId")]
        private int calendarId;

        [Column("Type")]
        private string type;

        [Column("Name")]
        private string name;

        [Column("Description")]
        private string description;

        [Column("Date")]
        private DateTime date;

        [Column("StartTime")]
        private DateTime startTime;

        [Column("EndTime")]
        private DateTime endTime;

        [Column("Location")]
        private string location;

        [Column("Note")]
        private string note;

        [Column("OtherId")]
        private int otherId;

        [NotMapped]
        private List<CalendarEvent> calendarEventList;

        public int CalendarEventId
        {
            get { return calendarEventId; }
            set { calendarEventId = value; }
        }
        public int CalendarId
        {
            get { return calendarId; }
            set { calendarId = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            set { endTime = value; }
            get { return endTime; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public int OtherId
        {
            get { return otherId; }
            set { otherId = value; }
        }
        [NotMapped]
        public List<CalendarEvent> CalendarEventList
        {
            set { calendarEventList = value; }
            get { return calendarEventList; }
        }
    }
}