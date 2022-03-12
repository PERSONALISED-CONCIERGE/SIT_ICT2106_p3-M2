using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class BussinessReview : IReview
    {
       
        public Review setReview( int account_id, int foodleisure_id, string review, string Date, Rating rating, string refrence_review)
        {
            Review newReview = new Review();
            newReview.account_id = 5;
            newReview.foodleisure_id = foodleisure_id;
            newReview.review = review;
            newReview.Date = Date;
            newReview.rating = Rating.One;
            newReview.refrence_review = refrence_review;
            return newReview;
        }
    }
}