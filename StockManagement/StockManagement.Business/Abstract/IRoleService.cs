using System;
using System.Collections.Generic;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Abstract
{
    public interface IRoleService
    {
        Role GetById(int roleId);
        List<Role> GetAllRoles();
        void Add(Role role);
        void Update(Role role);
        void Delete(Role role);
    }
}
