using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public int CreatedUserId { get; set; }
    }
}
