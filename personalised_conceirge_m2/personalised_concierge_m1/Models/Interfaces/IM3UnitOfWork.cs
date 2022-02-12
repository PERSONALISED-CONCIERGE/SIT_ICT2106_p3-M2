using System;
using personalised_concierge_m1.Models.Interfaces.Facilities;
using personalised_concierge_m1.Models.Interfaces.Inventories;
using personalised_concierge_m1.Models.Interfaces.Requests;

namespace personalised_concierge_m1.Models.Interfaces
{
    public interface IM3UnitOfWork : IDisposable
    {
        //m3 Interface UnitOfWork for Facilities
        IFacilityRepo FacilityDetails { get; }
        
        IFacilityBookingRepo FacilityBookingDetails { get; }
        
        IFeedbackRepo FeedbackDetails { get; }
        
        //m3 Interface UnitOfWork for Inventory
        IInventoryRepo InventoryDetails { get; }
        
        IInventoryCategoryRepo InventoryCategoryDetails { get; }
        
        IInventoryRequestRepo InventoryRequestDetails { get; }
        
        //M3 Requests
        IGuestRequestRepo GuestRequestDetails { get; }
        IRequestRepo RequestDetails { get; }
        IRequestTypeRepo RequestTypeDetails { get; }
        
        int Complete();
    }
}