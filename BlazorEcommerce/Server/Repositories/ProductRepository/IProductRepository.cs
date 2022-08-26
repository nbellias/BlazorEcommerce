using BlazorEcommerce.Shared.Entities;
using BlazorEcommerce.Shared.Responses;

namespace BlazorEcommerce.Server.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<ServiceResponse<List<Product>>> GetAllProductsAsync();
        Task<ServiceResponse<Product>> GetProductByIDAsync(Guid productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
        Task<ServiceResponse<ProductSearchResponse>> SearchProductsAsync(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestionsAsync(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProductsAsync();
        //void InsertProduct(Product product);
        //void DeleteProduct(int productID);
        //void UpdateProduct(Product product);
        //void Save();
    }
}
