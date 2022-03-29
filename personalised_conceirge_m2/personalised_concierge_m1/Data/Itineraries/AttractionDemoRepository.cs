using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using personalised_concierge_m1.Data;
using personalised_concierge_m1.Interface;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Repository
{
    public class AttractionDemoRepository : GenericRepo<AttractionDemo>, IAttractionDemoRepository
    {
        private readonly ConciergeContext _context;

        public AttractionDemoRepository(ConciergeContext context) : base(context)
        {
            _context = context;
        }

        public AttractionDemo findAttractionById(int id)
        {
            var attraction = _context.attractionDemo.Where(m => m.AttractionDemoId == id).FirstOrDefault();
            return attraction;
        }
    }
}