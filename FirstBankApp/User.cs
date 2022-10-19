using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBankApp
{
    public class User
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string AccountNumber { get; set; }

        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            
        }
    }
}
