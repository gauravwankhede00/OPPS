namespace WebAPI.Service.Interface
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync();
    }
}
