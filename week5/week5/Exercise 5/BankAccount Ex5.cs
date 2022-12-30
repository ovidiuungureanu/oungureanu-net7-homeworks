using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_5
{
    public class BankAccount_Ex5
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance
        {
            get { return balance; }
            set
            {
                if(balance < 0)
                {
                    throw new Exception("Balance can't be lower than 0");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public BankAccount_Ex5(string AccountNumber, string AccountHolder, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
            Bank.NumAccounts++;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount should be greater than 0");
            }

            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount should be greater than 0");
            }

            if (Balance - amount < 0)
            {
                throw new Exception("You don't have that much money");
            }

            this.Balance -= amount;
        }

        public double GetInterest()
        {
            return Bank.CalculateInterest(this.Balance);
        }
    }
}
