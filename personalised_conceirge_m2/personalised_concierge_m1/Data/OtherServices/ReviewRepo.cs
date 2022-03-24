using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Review> GetReviewByDateNFoodLiesure(int foodleisure_id, string date)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).Where(review => review.refrence_review == null && EF.Functions.Like(review.Date, date)).ToList();
        }

        public IEnumerable<Review> GetReviewByIDNFoodLiesure(int foodleisure_id, int id)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).Where(review => review.refrence_review == null && review.review_id == id).ToList();
        }

        public IEnumerable<Review> GetReviewByRateNFoodLiesure(int foodleisure_id, Rating rating)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).Where(review => review.refrence_review == null && review.rating == rating).ToList();
        }

        public IEnumerable<Review> GetReviewByDescriptionNFoodLiesure(int foodleisure_id, string description)
        {
            return _context.Reviews.Where(review => review.foodleisure_id == foodleisure_id).Where(review => review.refrence_review == null && EF.Functions.Like(review.Date, description)).ToList();
        }
    }
}