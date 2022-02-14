using personalised_concierge_m1.Data.FoodLeisureServices;
using personalised_concierge_m1.Data.Itineraries;
using personalised_concierge_m1.Data.OtherServices;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.UnitOfWorks
{
    public class M2UnitOfWork : IM2UnitOfWork
    {
        //Again, we are creating ConciergeContext here because unitofwork needs to talk to DB directly for save and dispose method
        private readonly ConciergeContext _context;
        
        public M2UnitOfWork(ConciergeContext context)
        {
            //TODO: All repo created will need to be instantiated within the UnitOfWork so that model classes that uses unitofwork can access the respective repo.
            
            this._context = context;
            
            FoodDeliveryDetails = new FoodDeliveryRepo(_context);
            NavigationDetails = new NavigationRepo(_context);
            ReviewDetails = new ReviewRepo(_context);
            TransportationDetails = new TransportationRepo(_context);
            TransportFareDetails = new TransportFaresRepo(_context);
            
            // M2 Itineraries
            BlogDetails = new BlogRepo(_context);
            BudgetDetails = new BudgetRepo(_context);
            ChecklistDetails = new ChecklistRepo(_context);
            ExpensesDetails = new ExpensesRepo(_context);
            ItineraryItemDetails = new ItineraryItemRepo(_context);
            ItineraryDetails = new ItineraryRepo(_context);
            
            // M2 Food Leisure Services
            AttractionDetails = new AttractionRepo(_context);
            FoodLeisureDetails = new FoodLeisureRepo(_context);
            FoodDetails = new FoodRepo(_context);

        }
        //TODO: All repo created property here. 
        
        #region Repository properties
        
        // Other Services
        public IFoodDeliveryRepo FoodDeliveryDetails { get; }
        public INavigationRepo NavigationDetails { get; }
        public IReviewRepo ReviewDetails { get; }
        public ITransportationRepo TransportationDetails { get; }
        public ITransportFaresRepo TransportFareDetails { get; }

        // Food Leisure services
        public IAttractionRepo AttractionDetails { get; }
        public IFoodLeisureRepo FoodLeisureDetails { get; }
        public IFoodRepo FoodDetails { get; }
        
        // Itineraries
        public IBlogRepo BlogDetails { get; }
        public IBudgetRepo BudgetDetails { get; }
        public IChecklistRepo ChecklistDetails { get; }
        public IExpensesRepo ExpensesDetails { get; }
        public IItineraryItemRepo ItineraryItemDetails { get; }
        public IItineraryRepo ItineraryDetails { get; }

        public ITransportFaresRepo TransportFaresRepo => throw new System.NotImplementedException();

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