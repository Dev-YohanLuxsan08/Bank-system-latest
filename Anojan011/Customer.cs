using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Customer
    {
        public int CustomerID;
        public string Name;
        public string Email;
        public List<Account> accounts = new List<Account>();

        public Customer(int CustomerID, string Name, string Email)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Email = Email;
        }
        public Customer() { }
        public void vie()
        {
            Console.WriteLine("here check");
            int custom=Convert.ToInt32(Console.ReadLine());
            var fin = accounts.Find(acc=>acc.CustomerID==custom);
               Console.WriteLine(fin.Balance);
        }
       
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public void RemoveAccount(Account account)
        {
            accounts.Remove(account);
        }
        public void GetAccountDetails()
        {
            Console.WriteLine($"Your Account Details: {CustomerID} {Name} {Email} {accounts}");
        }
    }
}
