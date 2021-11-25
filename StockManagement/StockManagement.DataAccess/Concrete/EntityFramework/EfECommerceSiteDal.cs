using System;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfECommerceSiteDal : EfEntityRepositoryBase<ECommerceSite, StockManagementContext>, IECommerceSiteDal
    {
        public EfECommerceSiteDal()
        {
        }
    }
}
