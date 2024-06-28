using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class SavingAccounts : Account
    {
        public SavingAccounts(int accountNumber, decimal balance, int customerID) : base(accountNumber, balance, customerID)
        {
        }
        public SavingAccounts() { }
    }
}
