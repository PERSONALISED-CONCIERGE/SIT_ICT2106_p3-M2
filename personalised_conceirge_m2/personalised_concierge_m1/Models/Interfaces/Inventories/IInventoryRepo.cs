using personalised_concierge_m1.Models.Entities.Inventories;

namespace personalised_concierge_m1.Models.Interfaces.Inventories
{
    public interface IInventoryRepo : IGenericRepo<Inventory>
    {
        IInventoryRepo getAllInventory();

        IInventoryRepo getInventoryById(int inventory_id);
    }
}