using WebAPI.DBContext;
using WebAPI.Repository.Implementation;

namespace WebAPI.Service
{
    public class CategoryService : Repository<Category>
    {
        public CategoryService(AppDbContext context) : base(context)
        {
        }
    }
}
