using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Dtos
{
    public class LoginDto :IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
