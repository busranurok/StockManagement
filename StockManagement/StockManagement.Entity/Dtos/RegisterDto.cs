using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Dtos
{
    public class RegisterDto :IDto
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
