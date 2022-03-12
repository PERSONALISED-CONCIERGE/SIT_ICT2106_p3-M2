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
        
        public Review GetReviewByID(int review_id)
        {
            return _context.Set<Review>().Find(review_id);
        }
        public IEnumerable<Review> GetAllReviews()
        {
            return _context.Set<Review>().ToList();
        }

        public IEnumerable<Review> GetReviewByFoodLeisure(int foodleisure_id)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).Where(review => review.refrence_review == null).ToList();
        }

        public IEnumerable<Review> GetBusinessReviewByFoodLeisure(int foodleisure_id)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).Where(review => review.refrence_review != null).ToList();
        }

    }
}