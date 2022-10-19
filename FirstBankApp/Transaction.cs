using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstBankApp
{
    public class Transaction
    {
        private string accountNumber;
        private bool shouldSetUpAccount = true;
        private Stack<Deposit> deposits;
        private Stack<Withdrawal> withdrawals;
        private Stack<Balance> balances;

        public Transaction(string accountNumber)
        {
            this.accountNumber = accountNumber;
            deposits = new Stack<Deposit>();
            withdrawals = new Stack<Withdrawal>();
            balances = new Stack<Balance>();
        }


        public String GetAccountNumber()
        {
            return accountNumber;   
        }

        public void SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public bool GetShouldSetUpAccount()
        {
            return shouldSetUpAccount;
        }

        public void SetShouldSetUpAccount(bool shouldSetUpAccount)
        {
            this.shouldSetUpAccount = shouldSetUpAccount;
        }


        public Stack<Deposit> GetDeposits()
        {
            return deposits;
        }

        public void SetDeposit(Deposit deposit)
        {
            deposits.Push(deposit);
        }

        public Stack<Withdrawal> GetWithdrawals()
        {
            return withdrawals;
        }


        public void SetWithdrawal(Withdrawal withdrawal)
        {
            withdrawals.Push(withdrawal);
        }

        public Stack<Balance> GetBalances()
        {
            return balances;
        }

        public void SetBalance(Balance balance)
        {
            balances.Push(balance);
        }
    }
}
