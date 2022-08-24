using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<ServiceResponse<List<Category>>> GetAllCategoriesAsync();
        Task<ServiceResponse<Category>> GetCategoryByIDAsync(Guid categoryId);
        
        //void InsertCategory(Category Category);
        //void DeleteCategory(int CategoryID);
        //void UpdateCategory(Category Category);
        //void Save();
    }
}
