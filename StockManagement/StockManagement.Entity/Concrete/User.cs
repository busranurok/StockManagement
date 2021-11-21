using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Lastname { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
