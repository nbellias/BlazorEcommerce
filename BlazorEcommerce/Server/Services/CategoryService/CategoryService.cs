using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ServiceResponse<Category>> GetCategoryAsync(Guid categoryId)
        {
            var response = await _categoryRepository.GetCategoryByIDAsync(categoryId);

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoryListAsync()
        {
            var response = await _categoryRepository.GetAllCategoriesAsync();

            return response;
        }
    }
}
