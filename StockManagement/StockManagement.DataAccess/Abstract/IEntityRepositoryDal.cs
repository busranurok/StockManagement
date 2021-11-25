using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using StockManagement.Entity.Abstract;
namespace StockManagement.DataAccess.Abstract
{
    public interface IEntityRepositoryDal<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter, bool v);
    }
}
