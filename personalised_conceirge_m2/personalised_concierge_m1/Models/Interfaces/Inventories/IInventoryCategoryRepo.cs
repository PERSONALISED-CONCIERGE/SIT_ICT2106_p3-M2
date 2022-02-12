using personalised_concierge_m1.Models.Entities.Inventories;

namespace personalised_concierge_m1.Models.Interfaces.Inventories
{
    public interface IInventoryCategoryRepo : IGenericRepo<InventoryCategory>
    {
        IInventoryCategoryRepo getAllInventoryCategory();
        
        IInventoryCategoryRepo getInvCateById(int invcate_id);
    }
}