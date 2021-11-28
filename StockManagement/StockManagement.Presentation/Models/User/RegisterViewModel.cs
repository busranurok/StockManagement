using System;
namespace StockManagement.Presentation.Models.User
{
    public class RegisterViewModel
    {
        public String Name { get; set; }
        public String Lastname { get; set; }
        public String Password { get; set; }
        public String PasswordAgain { get; set; }
        public String Email { get; set; }
        public int RoleId { get; set; }

    }
}
