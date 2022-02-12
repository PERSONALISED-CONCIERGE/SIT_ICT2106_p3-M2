using personalised_concierge_m1.Models.Entities.UserDetails;
using personalised_concierge_m1.Models.Interfaces.UserDetails;

namespace personalised_concierge_m1.Data.UserDetails
{
    public class UserRoleRepo : GenericRepo<UserRole>, IUserRoleRepo
    {
        public UserRoleRepo(ConciergeContext context) : base(context)
        {
        }
        public IUserRoleRepo getAllUserRoles()
        {
            throw new System.NotImplementedException();
        }
        public IUserRoleRepo getUseRoleById(int room_Id)
        {
            throw new System.NotImplementedException();
        }
    }
}