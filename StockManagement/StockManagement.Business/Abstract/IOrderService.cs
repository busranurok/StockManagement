using System;
using System.Collections.Generic;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Abstract
{
    public interface IOrderService
    {
        Order GetById(int orderId);
        List<Order> GetAllOrders();
        List<Order> GetOrdersByECommerceSite(int eCommerceId);
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
