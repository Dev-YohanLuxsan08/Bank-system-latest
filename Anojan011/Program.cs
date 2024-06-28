using Banksystem;
using Microsoft.VisualBasic;
using System.Xml.Linq;

internal class Program
{
    static Bank Bank = new Bank();
    static Account Account = new Account();
    static Customer Customer = new Customer();

    static void Main(string[] args)
    {

        Console.WriteLine("\tHello, Jerrobert sir welcome to our bank app\n\t Bank checking");
       
        Menu();

    }
    static void Menu()
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("1.Create a Customer\n2.Create an Account\n3.Deposit Funds\n4.Withdraw Funds\n5.Transfer Funds\n6.View Customer Details\n7.Exit");
            int value1 = Convert.ToInt32(Console.ReadLine());
            switch (value1)
            {
                case 1:
                    CustomerCreate();
                    break;
                case 2:
                    CreateAccount();
                    Console.WriteLine("Enter Your Name");
                    break;
                case 3:
                    deposit();
                    break;
                case 4:
                    withdraw();
                    break;
                case 5:
                    Transfer();
                    break;
                case 6:
                    view();
                    break;
                case 7:
                    check = false;
                    break;
            }
        }


    }
    static void CustomerCreate()
    {
        Console.WriteLine("1.Enter Your CustomerID");
        int Customerid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1.Enter Your Name");
        string Customername = Console.ReadLine();
        Console.WriteLine("1.Enter Your Email");
        string Email = Console.ReadLine();
        Customer custom = new Customer(Customerid, Customername, Email);
        Bank.AddCustomer(custom);
    }
    static void CreateAccount()
    {
        //3.Select Account Type(1 for Savings, 2 for Checking):
        Console.WriteLine("1.Enter Your CustomerID");
        int Customerid = Convert.ToInt32(Console.ReadLine());
        var findcustomer = Bank.Customers.Find(cus => cus.CustomerID == Customerid);
        if (findcustomer != null)
        {
            Console.WriteLine("Enter your Account Number :");
            int account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Account Type\n\t1.saving Account\n\t2.Checking  Account");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Account account1 = new Account(account, amount);
            Customer.AddAccount(account1);



            switch (type)
            {
                case 1:
                    SavingAccounts saving = new SavingAccounts(account, amount, Customerid);
                    break;
                case 2:
                    CheckingAccount checking = new CheckingAccount(account, amount, Customerid);
                    break;
            }
            



        }
        else
        {
            Console.WriteLine("Your Customer id isnot valid..........");
            CustomerCreate();
        }

    }
    static void deposit()
    {
        Console.WriteLine("Enter your Accountnumber :");
        int accountnum = Convert.ToInt32(Console.ReadLine());
        var acc = Customer.accounts.Find(cus => cus.AccountNumber == accountnum);
        if (acc != null)
        {
            Console.WriteLine("Enter your amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            acc.Balance = acc.Balance+amount;
            //Account.Deposit(amount);
            Console.WriteLine("Your deposite sucessfull");
        }
        else
        {
            Console.WriteLine("your account not valid");
        }


    }
    static void withdraw()
    {
        Console.WriteLine("Enter your Accountnumber :");
        int accountnum = Convert.ToInt32(Console.ReadLine());
        var acc = Customer.accounts.Find(cus => cus.AccountNumber == accountnum);
        if (acc != null)
        {
            Console.WriteLine("Enter your amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            acc.Balance = acc.Balance-amount;
            Console.WriteLine("Your Withdraw Sucessfull");
            //Account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("your account not valid");

        }
        Console.WriteLine("your balance" + Account.Balance);



    }
    static void Transfer()
    {
        Console.WriteLine("Enter source Account Number :");
        int send = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Destination AccountNumber :");
        int Recieve = Convert.ToInt32(Console.ReadLine());
        var acc = Customer.accounts.Find(cus => cus.AccountNumber == send);
        var acc1 =Customer.accounts.Find(cus => cus.AccountNumber == Recieve);
        if (acc1 != null )
        {
            if(acc != null)
            {
                Console.WriteLine("Enter Amount To Transfer");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                acc.Balance = acc.Balance - amount;
                acc1.Balance = acc1.Balance + amount;
                Console.WriteLine("your Transfer Sucessfull");
            }
            else
            {
                Console.WriteLine("hello this second");
            }

        }
        else
        {
            Console.WriteLine("hello this fiors");
        }
       
    }
    static void view()
    {
       
        Console.WriteLine("Enter Your Account number");
        int bala = Convert.ToInt32(Console.ReadLine());
        var bal = Customer.accounts.Find(cus => cus.AccountNumber == bala);
        if (bal != null)
        {
            Console.WriteLine($"Your Balance :{bal.Balance}\nYour AccountNumber : {bal.AccountNumber}");
        }
        else
        {
            Console.WriteLine("YOUR  account is null");
        }
    }

}