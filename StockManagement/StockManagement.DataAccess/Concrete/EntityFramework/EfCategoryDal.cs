using System;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, StockManagementContext>, ICategoryDal
    {
        public EfCategoryDal()
        {
        }
    }
}
