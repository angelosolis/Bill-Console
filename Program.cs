using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bill_Console.Bill;

namespace Bill_Console
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Bill.IBillDetails bill = new billinterface(12345, "PIONEER", 1000);
                bill.DisplayBillDetails();
            }
    }
}
