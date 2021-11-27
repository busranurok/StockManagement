using System;
using System.Collections.Generic;
using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.Entity.Concrete;

namespace StockManagement.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int orderId)
        {
            return _orderDal.Get(filter: o=> o.Id == orderId, true);
        }

        public List<Order> GetOrdersByECommerceSite(int eCommerceId)
        {
            return _orderDal.GetAll(filter: o => o.ECommerceSiteId == eCommerceId);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
