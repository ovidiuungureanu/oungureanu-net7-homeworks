using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace week5.Exercise_1
{
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private decimal balance;
        private List<Transaction> transactions;

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        public decimal Balance { get; set; }

        public BankAccount(int accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            this.transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount should be greater than 0");
            }
            this.Balance += amount;

            Transaction transaction = new Transaction();
            transaction.type = "Deposit";
            transaction.amount = amount;
            transaction.timestamp = DateTime.Now;
            transactions.Add(transaction);
        }

        public void Withdraw(decimal amount)
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

            Transaction transaction = new Transaction();
            transaction.type = "Withdraw";
            transaction.timestamp = DateTime.Now;
            transaction.amount = amount;
            transactions.Add(transaction);
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }

        public List<Transaction> GetTransactionHistory()
        {
            return this.transactions;
        }
    }
}
