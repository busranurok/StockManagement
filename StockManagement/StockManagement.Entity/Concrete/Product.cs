using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public String Color { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
