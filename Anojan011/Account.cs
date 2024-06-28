using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Account
    {
        public int AccountNumber;
        public decimal Balance;
        public int CustomerID;

        public Account()
        {

        }
        public Account(int AccountNumber, decimal Balance)
        {
           this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }
        public Account(int accountNumber, decimal balance, int customerID)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            CustomerID = customerID;
        }

        public decimal Deposit(decimal amount)
        {
           this.Balance = Balance + amount;
            
            return Balance;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount < Balance)
            {
                this.Balance = Balance - amount;
                return Balance;
            }
            else
            {
                Console.WriteLine("Your account Balance is low");
            }
            return Balance;

        }
        public decimal Withdraw(double amount)
        {

            Balance = Balance - (Balance * Convert.ToDecimal(amount));
            return Balance;



        }

        public void GetBalance()
        {
            Console.WriteLine($"Your account Balance{this.Balance}");

        }

    }
}

