using System;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, StockManagementContext>, IUserDal
    {
        public EfUserDal()
        {
        }
    }
}
