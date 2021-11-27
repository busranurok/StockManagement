using System;
using System.Collections.Generic;
using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Concrete
{
    public class RoleManager :IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(Role role)
        {
            _roleDal.Delete(role);
        }

        public List<Role> GetAllRoles()
        {
            return _roleDal.GetAll();
        }

        public Role GetById(int roleId)
        {
            return _roleDal.Get(filter: r => r.Id == roleId, true);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
