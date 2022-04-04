using System;
namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public interface IReview
    {
        public Review setReview( int account_id, int foodleisure_id, string review, string Date,
                                 Rating rating, string refrence_review);

    }
}
