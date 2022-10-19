using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBankApp
{
    public class Withdrawal
    {
        public double Amount { get; set; }
        public Withdrawal(double amount)
        {
            Amount = amount;
        }
    }

}
