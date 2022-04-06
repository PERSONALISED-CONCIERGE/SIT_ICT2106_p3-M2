using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using personalised_concierge_m1.Models.Entities.UserDetails;
namespace personalised_concierge_m1.Models.Entities.Attraction
{
    public class AttractionLocation
    {

        public string attractionAddress { get; set; }
        public double attractionLat { get; set; }
        public double attractionLon { get; set; }

    }
}