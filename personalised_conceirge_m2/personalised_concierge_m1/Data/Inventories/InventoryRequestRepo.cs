using System;
using personalised_concierge_m1.Models.Entities.Inventories;
using personalised_concierge_m1.Models.Interfaces.Inventories;

namespace personalised_concierge_m1.Data.Inventories
{
    public class InventoryRequestRepo : GenericRepo<InventoryRequest>, IInventoryRequestRepo
    {
        public InventoryRequestRepo(ConciergeContext context) : base(context)
        {
            
        }

        public IInventoryRequestRepo getAllInventoryRequest()
        {
            throw new System.NotImplementedException();
        }

        public IInventoryRequestRepo getInvReqById(int invreq_id)
        {
            throw new System.NotImplementedException();
        }

    }
}