using System;
using System.Collections.Generic;
using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
     
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAllUsers()
        {
            return _userDal.GetAll();
        }

        public User GetById(int userId)
        {
            return _userDal.Get(filter: u => u.Id == userId, true);
        }

        public User GetUserByEmail(string email)
        {
            return _userDal.Get(filter: e => e.Email == email, true);
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _userDal.Get(filter: e => e.Email == email && e.Password == password, true);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
