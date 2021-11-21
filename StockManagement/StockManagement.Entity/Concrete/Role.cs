using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Concrete
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
        public String Name { get; set; }
        public int AuthenticatedSiteId { get; set; }
        public String Description { get; set; }
    }
}
