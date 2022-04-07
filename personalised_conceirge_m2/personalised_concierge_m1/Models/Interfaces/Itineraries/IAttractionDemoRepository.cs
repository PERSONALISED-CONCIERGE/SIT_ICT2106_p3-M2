using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Interface
{
    public interface IAttractionDemoRepository : IGenericRepo<AttractionDemo>
    {
        AttractionDemo findAttractionById(int id);
    }
}