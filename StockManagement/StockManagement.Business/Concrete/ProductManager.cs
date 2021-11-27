using System;
using System.Collections.Generic;
using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(filter: p=> p.Id == productId, true);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
