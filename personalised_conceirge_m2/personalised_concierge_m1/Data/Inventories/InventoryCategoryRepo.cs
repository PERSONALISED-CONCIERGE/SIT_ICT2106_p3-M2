using System;
using personalised_concierge_m1.Models.Entities.Inventories;
using personalised_concierge_m1.Models.Interfaces.Inventories;

namespace personalised_concierge_m1.Data.Inventories
{
    public class InventoryCategoryRepo : GenericRepo<InventoryCategory>, IInventoryCategoryRepo
    {
        public InventoryCategoryRepo(ConciergeContext context) : base(context)
        {
            
        }

        public IInventoryCategoryRepo getAllInventoryCategory()
        {
            throw new System.NotImplementedException();
        }

        public IInventoryCategoryRepo getInvCateById(int invcate_id)
        {
            throw new System.NotImplementedException();
        }
    }
}