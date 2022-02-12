using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Interfaces.UserDetails
{
    public interface IUserRoleRepo : IGenericRepo<UserRole>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IUserRoleRepo getAllUserRoles();
        IUserRoleRepo getUseRoleById(int role_id);   
    }
}