using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Bank
    {
        public string Name;
        public List<Customer> Customers = new List<Customer>();


        public void AddCustomer(Customer customers)
        {
            Customers.Add(customers);
        }
        public void view()
        {
            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.CustomerID);
            }
            //public void GetCustomerDetails(Customer customer) 
            //{

            //}
            //public int TransferFunds()
            //{

            //return 0; 
            //}
        }
    }
}

