using System;
using System.Collections.Generic;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int productId);
        List<Product> GetAllProducts();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
