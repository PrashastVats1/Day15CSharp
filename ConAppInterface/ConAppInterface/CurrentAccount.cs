using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterface
{
    internal class CurrentAccount : IAccount
    {
        double cBal;
        public CurrentAccount()
        {
            cBal = 50000;
        }
        public double Balance => cBal;
        public double Deposit(double amount)
        {
            cBal += amount;
            return cBal;
        }
        public double WithDraw(double amount)
        {
            if(amount<=cBal)
            {
                cBal -= amount;
                Console.WriteLine("Transaction Success");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine("Transaction Declined");
            }
            return cBal;
        }
    }
}
