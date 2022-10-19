using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBankApp
{
    public class Deposit
    {
        public double Amount { get; set; }

        public Deposit(double amount)
        {
            Amount = amount;
        }
    }
}
