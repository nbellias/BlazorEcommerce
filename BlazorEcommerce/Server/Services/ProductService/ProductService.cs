using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProductsAsync()
        {
            var response = await _productRepository.GetFeaturedProductsAsync();

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(Guid productId)
        {
            var response = await _productRepository.GetProductByIDAsync(productId);

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = await _productRepository.GetAllProductsAsync();

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = await _productRepository.GetProductsByCategoryAsync(categoryUrl);

            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestionsAsync(string searchText)
        {
            var response = await _productRepository.GetProductSearchSuggestionsAsync(searchText);

            return response;
        }

        public async Task<ServiceResponse<ProductSearchResultDTO>> SearchProductsAsync(string searchText, int page)
        {
            var response = await _productRepository.SearchProductsAsync(searchText, page);

            return response;
        }
    }
}
