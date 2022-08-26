﻿using BlazorEcommerce.Shared.Entities;
using BlazorEcommerce.Shared.Responses;

namespace BlazorEcommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        event Action OnChange;
        List<Category> Categories { get; set; }
        List<Category> AdminCategories { get; set; }
        Task GetCategories();
        Task GetAdminCategories();
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(Guid categoryId);
        Category CreateNewCategory();
    }
}
