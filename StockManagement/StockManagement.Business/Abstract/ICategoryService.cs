using System;
using System.Collections.Generic;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int categoryId);
        List<Category> GetAllCategories();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
