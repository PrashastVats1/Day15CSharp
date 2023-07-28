using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterface
{
    internal class SavingAccount : IAccount
    {
        double sBal;
        public SavingAccount()
        {
            sBal = 20000;
        }
        public double Balance => sBal;
        public double Deposit(double amount)
        {
            sBal += amount;
            return sBal;
        }
        public double WithDraw(double amount)
        {
            if (amount <= sBal)
            {
                if (sBal - amount > 500)
                {
                    sBal -= amount;
                    Console.WriteLine("Transaction Success!!");
                }
                else
                {
                    Console.WriteLine("Minimum balance to be maintained is 5000");
                }
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine("Transaction declined");
            }
            return sBal;
        }
    }
}
