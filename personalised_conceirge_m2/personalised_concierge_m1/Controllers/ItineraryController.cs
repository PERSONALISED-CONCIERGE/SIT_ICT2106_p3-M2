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
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Data.Itineraries;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Controllers
{
    public class ItineraryController : Controller
    {
        private Itinerary itinerary = new Itinerary();

        private readonly IM2UnitOfWork _m2UnitOfWork;

        public ItineraryController(IM2UnitOfWork m2UnitOfWork)
        {
            _m2UnitOfWork = m2UnitOfWork;
        }

        public IActionResult Index() { 
        
            return View(itinerary);
        }
    }
}
