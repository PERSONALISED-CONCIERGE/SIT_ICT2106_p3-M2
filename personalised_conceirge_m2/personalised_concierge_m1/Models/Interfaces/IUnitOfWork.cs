using System;
using personalised_concierge_m1.Models.Interfaces.HotelServices;
using personalised_concierge_m1.Models.Interfaces.RoomDetails;
using personalised_concierge_m1.Models.Interfaces.UserDetails;

namespace personalised_concierge_m1.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Unit of work Interface will define the repository properties and used by controllers.
        //TODO: all the repo property goes here:

        // Room Details
        IReservationRepo ReservationDetails { get; }
        IRoomRepo RoomDetails { get; }
        IRoomTypeRepo RoomTypeDetails { get; }
        
        // Hotel Services
        IHotelServiceRepo HotelServiceDetails { get; }
        
        // User Details
        IAccountRepo AccountDetails { get; }
        IUserRoleRepo UserRoleDetails { get; }
        
        int Complete();
    }
}