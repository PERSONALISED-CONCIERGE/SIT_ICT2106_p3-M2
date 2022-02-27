using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.OtherServices
{
    public class ReviewRepo:GenericRepo<Review>,IReviewRepo
    {
        public ReviewRepo(ConciergeContext context) : base(context)
        {
            
        }
        
        //implementation of non-generic interface methods
        public IReviewRepo getAllReviews()
        {
            throw new System.NotImplementedException();
        }

        public IReviewRepo getReviewById(int review_id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Review> GetReviewByFoodLeisure(int foodleisure_id)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).ToList();
        }
    }
}