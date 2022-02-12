using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Interfaces.UserDetails
{
    public interface IAccountRepo : IGenericRepo<Account>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IAccountRepo getAllAccounts();
        IAccountRepo getAccountById(int account_id);   
    }
}