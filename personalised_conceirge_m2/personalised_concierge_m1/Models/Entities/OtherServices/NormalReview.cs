using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
  
    public class NormalReview:IReview
    {
        public Review setReview( int account_id, int foodleisure_id, string review, string Date, Rating rating, string refrence_review)
        {
            Review newReview = new Review();
            newReview.account_id = 2;
            newReview.foodleisure_id = foodleisure_id;
            newReview.review = review;
            newReview.Date = Date;
            newReview.rating = rating;
            newReview.refrence_review = null;
            return newReview;
        }
    }
}
