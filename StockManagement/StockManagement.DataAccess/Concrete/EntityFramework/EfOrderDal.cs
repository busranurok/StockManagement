using System;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, StockManagementContext>, IOrderDal
    {
        public EfOrderDal()
        {
        }
    }
}
