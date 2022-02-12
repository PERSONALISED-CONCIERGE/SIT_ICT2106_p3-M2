using personalised_concierge_m1.Models.Entities.UserDetails;
using personalised_concierge_m1.Models.Interfaces.UserDetails;

namespace personalised_concierge_m1.Data.UserDetails
{
    public class AccountRepo : GenericRepo<Account>, IAccountRepo
    {
        public AccountRepo(ConciergeContext context) : base(context)
        {
        }
        public IAccountRepo getAllAccounts()
        {
            throw new System.NotImplementedException();
        }
        public IAccountRepo getAccountById(int account_id)
        {
            throw new System.NotImplementedException();
        }
    }
}