using System;
using personalised_concierge_m1.Models.Entities.Inventories;
using personalised_concierge_m1.Models.Interfaces.Inventories;

namespace personalised_concierge_m1.Data.Inventories
{
    public class InventoryRepo : GenericRepo<Inventory>, IInventoryRepo
    {
        public InventoryRepo(ConciergeContext context) : base(context)
        {
            
        }

        public IInventoryRepo getAllInventory()
        {
            throw new System.NotImplementedException();
        }

        public IInventoryRepo getInventoryById(int inventory_id)
        {
            throw new System.NotImplementedException();
        }
    }
}