using System;
namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class ReviewFactory
    {
        public ReviewFactory()
        {
          
        }

        public static IReview makeReview (string refrence_review)
        {
            if (refrence_review == null)
            {
                return new NormalReview();
            }
            else
            {
                return new BussinessReview();
            }
        }
    }
}
