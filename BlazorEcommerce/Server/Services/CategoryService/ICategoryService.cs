﻿using BlazorEcommerce.Shared.Entities;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategoryListAsync();
        Task<ServiceResponse<Category>> GetCategoryAsync(Guid categoryId);
    }
}
