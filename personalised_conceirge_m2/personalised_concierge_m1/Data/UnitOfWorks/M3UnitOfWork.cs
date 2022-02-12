using personalised_concierge_m1.Data.Facilities;
using personalised_concierge_m1.Data.Inventories;
using personalised_concierge_m1.Data.Requests;
using personalised_concierge_m1.Data.RoomDetails;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Interfaces.Facilities;
using personalised_concierge_m1.Models.Interfaces.Inventories;
using personalised_concierge_m1.Models.Interfaces.Requests;

namespace personalised_concierge_m1.Data.UnitOfWorks
{
    public class M3UnitOfWork : IM3UnitOfWork
    {
        private readonly ConciergeContext _context;
        
        //Unit of work for m3 Facilities and Inventories
        public M3UnitOfWork(ConciergeContext context)
        {
            this._context = context;
            
            // Facilities
            FacilityDetails = new FacilityRepo(_context);
            FacilityBookingDetails = new FacilityBookingRepo(_context);
            FeedbackDetails = new FeedbackRepo(_context);
            
            // Inventories
            InventoryDetails = new InventoryRepo(_context);
            InventoryCategoryDetails = new InventoryCategoryRepo(_context);
            InventoryRequestDetails = new InventoryRequestRepo(_context);
            
            //Guest Requests
            GuestRequestDetails = new GuestRequestRepo(_context);
            RequestDetails = new RequestRepo(_context);
            RequestTypeDetails = new RequestTypeRepo(_context);
        }
        
        #region Repository properties
        //M3 facilities interface repo
        public IFacilityRepo FacilityDetails { get; }
        public IFacilityBookingRepo FacilityBookingDetails { get; }
        public IFeedbackRepo FeedbackDetails { get; }
        
        //M3 inventories interface repo
        public IInventoryRepo InventoryDetails { get; }
        public IInventoryCategoryRepo InventoryCategoryDetails { get; }
        public IInventoryRequestRepo InventoryRequestDetails { get; }
        
        //M3 Requests
        public IGuestRequestRepo GuestRequestDetails { get; }
        public IRequestRepo RequestDetails { get; }
        public IRequestTypeRepo RequestTypeDetails { get; }
        
        
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