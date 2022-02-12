using personalised_concierge_m1.Models.Entities.Inventories;

namespace personalised_concierge_m1.Models.Interfaces.Inventories
{
    public interface IInventoryRequestRepo : IGenericRepo<InventoryRequest>
    {
        IInventoryRequestRepo getAllInventoryRequest();

        IInventoryRequestRepo getInvReqById(int invreq_id);
    }
}