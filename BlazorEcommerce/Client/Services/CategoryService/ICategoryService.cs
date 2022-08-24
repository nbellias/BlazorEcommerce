﻿using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();
        Task<ServiceResponse<Category>> GetCategory(Guid categoryId);
    }
}
