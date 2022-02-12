using System;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Models.Interfaces
{
    public interface IM2UnitOfWork : IDisposable
    {
        //Unit of work Interface will define the repository properties and used by controllers.
        //TODO: all the repo property goes here:
        IFoodDeliveryRepo FoodDeliveryDetails { get; }
        INavigationRepo NavigationDetails { get; }
        IReviewRepo ReviewDetails { get; }
        ITransportationRepo TransportationDetails { get; }
        
        // Itineraries
        IBlogRepo BlogDetails { get; }
        IBudgetRepo BudgetDetails { get; }
        IChecklistRepo ChecklistDetails { get; }
        IExpensesRepo ExpensesDetails { get; }
        IItineraryItemRepo ItineraryItemDetails { get; }
        IItineraryRepo ItineraryDetails { get; }

        // Food Leisure Services
        IAttractionRepo AttractionDetails { get; }
        IFoodLeisureRepo FoodLeisureDetails { get; }
        IFoodRepo FoodDetails { get; }
        
        
        int Complete();
    }
}