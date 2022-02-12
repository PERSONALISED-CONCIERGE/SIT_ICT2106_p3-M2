using personalised_concierge_m1.Data.HotelServices;
using personalised_concierge_m1.Data.RoomDetails;
using personalised_concierge_m1.Data.UserDetails;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Interfaces.HotelServices;
using personalised_concierge_m1.Models.Interfaces.RoomDetails;
using personalised_concierge_m1.Models.Interfaces.UserDetails;

namespace personalised_concierge_m1.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        //Again, we are creating ConciergeContext here because unitofwork needs to talk to DB directly for save and dispose method
        private readonly ConciergeContext _context;

        public UnitOfWork(ConciergeContext context)
        {
            //TODO: All repo created will need to be instantiated within the UnitOfWork so that model classes that uses unitofwork can access the respective repo.

            this._context = context;
            
            // M1 Room Details
            RoomDetails = new RoomRepo(_context);
            ReservationDetails = new ReservationRepo(_context);
            RoomTypeDetails = new RoomTypeRepo(_context);
            
            // M1 Hotel Services
            HotelServiceDetails = new HotelServiceRepo(_context);
            
            // M1 User Details
            AccountDetails = new AccountRepo(_context);
            UserRoleDetails = new UserRoleRepo(_context);
            
        }
        //TODO: All repo created property here. 

        #region Repository properties
        
        // Room Details
        public IReservationRepo ReservationDetails { get; }
        public IRoomTypeRepo RoomTypeDetails { get; }
        public IRoomRepo RoomDetails { get; }
        
        // Hotel Services
        public IHotelServiceRepo HotelServiceDetails { get; }
        
        // User Details
        public IAccountRepo AccountDetails { get; }
        public IUserRoleRepo UserRoleDetails { get; }
        
        #endregion
        
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}