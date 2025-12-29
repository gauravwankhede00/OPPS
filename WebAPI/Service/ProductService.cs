using WebAPI.DBContext;
using WebAPI.Repository.Implementation;
using WebAPI.Service.Interface;

namespace WebAPI.Service
{
    public class ProductService : Repository<Product>, IProductCategoryService
    {
        public ProductService(AppDbContext context)  : base(context)
        {
        }

        public Task<IEnumerable<Product>> GetProductsByCategoryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
