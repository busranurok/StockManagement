using System;
using System.Collections.Generic;
using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(filter: c => c.Id == categoryId, true);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
