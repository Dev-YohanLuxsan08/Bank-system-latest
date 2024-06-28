using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Transection
    {
        public int TransectionID;
        public int AccountNumber;
        public int Amount;
        public string TransectionType;
        public string Date;


        public void TransectionDetail()
        {
            Console.WriteLine($"Transection Id : {TransectionID} Account : {AccountNumber} Amount : {Amount}");
        }
    }
}

