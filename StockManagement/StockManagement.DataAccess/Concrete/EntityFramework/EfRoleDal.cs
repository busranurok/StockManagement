using System;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfRoleDal : EfEntityRepositoryBase<Role, StockManagementContext>, IRoleDal
    {
        public EfRoleDal()
        {
        }
    }
}
