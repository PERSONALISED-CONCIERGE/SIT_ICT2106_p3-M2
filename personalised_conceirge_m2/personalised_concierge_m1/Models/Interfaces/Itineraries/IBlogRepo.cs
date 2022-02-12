using personalised_concierge_m1.Models.Entities.Itineraries;


namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IBlogRepo : IGenericRepo<Blog>
    {
        IBlogRepo getAllBlogs();
        IBlogRepo getBlogById(int blog_id);
    }
}
