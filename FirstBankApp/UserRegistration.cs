using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBankApp
{

    public class UserRegistration
    {
        public List<User> users { get; set; }
        public List<Transaction> TransactionList { get; set; }

        //public UserRegistration()
        //{
            
        //}

        public User GetUser(string email, string password)
        {
            User searchUser = null;
            foreach(var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    searchUser = user; break;   
                }
            }
            return searchUser;
        }

        public string GetFullName(User user)
        {
            string returnValue = "";
            if (user != null)
            {
                returnValue = user.FullName;
            }
            return returnValue;
        }

    }
}
