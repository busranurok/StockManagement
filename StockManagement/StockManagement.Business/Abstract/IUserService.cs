using System;
using System.Collections.Generic;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Abstract
{
    public interface IUserService
    {
        User GetById(int userId);
        List<User> GetAllUsers();
        User GetUserByEmail(string email);
        User GetUserByEmailAndPassword(string email, string password);
        void Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
