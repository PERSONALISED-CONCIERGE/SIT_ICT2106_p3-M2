using System.Collections.Generic;
using personalised_concierge_m1.Models.Entities.Itineraries;


namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IBlogRepo : IGenericRepo<Blog>
    {
        IEnumerable<Blog> GetAllBlogs();
        Blog GetBlogByID(int blog_id);
    }
}
