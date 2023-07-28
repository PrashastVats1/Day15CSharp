using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount account = null;
            Console.WriteLine("Choose account type");
            Console.WriteLine("1. Savings       2. Current");
            int acType = int.Parse(Console.ReadLine());
            switch(acType)
            {
                case 1:
                    {
                        account = new SavingAccount();
                        break;
                    }
                case 2:
                    {
                        account = new CurrentAccount();
                        break;
                    }
                default:
                    return;
            }
            Console.WriteLine("Choose operation 1. Balance      2. Deposit      3.Withdraw");
            int operation = int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    {
                        Console.WriteLine(account.Balance);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(account.Deposit(1200));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(account.WithDraw(1200));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Inavlid Operation");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
