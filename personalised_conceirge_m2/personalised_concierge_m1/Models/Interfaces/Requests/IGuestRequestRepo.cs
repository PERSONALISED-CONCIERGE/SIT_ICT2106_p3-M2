using personalised_concierge_m1.Models.Entities.Requests;

namespace personalised_concierge_m1.Models.Interfaces.Requests
{
    public interface IGuestRequestRepo:IGenericRepo<GuestRequest>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity

        IGuestRequestRepo getAllGuestRequest();
        IGuestRequestRepo getGuestRequestById(int guest_id, int request_id);
    }
}