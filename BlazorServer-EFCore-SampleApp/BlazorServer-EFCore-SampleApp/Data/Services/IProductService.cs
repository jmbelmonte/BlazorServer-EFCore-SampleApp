using BlazorServer_EFCore_SampleApp.Data.Entities;

namespace BlazorServer_EFCore_SampleApp.Data.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
