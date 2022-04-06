using personalised_concierge_m1.Models.Entities.Attraction;
using personalised_concierge_m1.Models.Interfaces.Attraction;

namespace personalised_concierge_m1.Data.AttractionServices
{
    public class AttractionVoteRepo : GenericRepo<Attraction>, IAttractionVoteRepo
    {
        public AttractionVoteRepo(ConciergeContext context) : base(context)
        {
        }
        public IAttractionVoteRepo getAllAttractionVotes()
        {
            throw new System.NotImplementedException();
        }

    }
}