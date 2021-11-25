using System;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, StockManagementContext>, IProductDal
    {
        public EfProductDal()
        {
        }
    }
}
