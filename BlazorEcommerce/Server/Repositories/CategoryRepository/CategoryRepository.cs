using BlazorEcommerce.Shared.Entities;
using BlazorEcommerce.Shared.Responses;

namespace BlazorEcommerce.Server.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetAllCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Category>> GetCategoryByIDAsync(Guid categoryId)
        {
            var response = new ServiceResponse<Category>();
            var product = await _context.Categories.FindAsync(categoryId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this category does not exist";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }
    }
}
