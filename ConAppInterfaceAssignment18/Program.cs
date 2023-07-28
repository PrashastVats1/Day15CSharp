using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterfaceAssignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone("");
            var laptop = new Laptop("");
            string input;
            do
            {
                Console.WriteLine("Enter the Smartphone Model: ");
                smartphone.Model = Console.ReadLine();
                Console.WriteLine("Enter the Laptop Brand: ");
                laptop.Brand = Console.ReadLine();
                Console.WriteLine("Enter the charging time for the Smartphone (in minutes): ");
                int smartphoneChargeTime = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the charging time for Laptop (in minutes): ");
                int laptopChargeTime = int.Parse(Console.ReadLine());
                //Connecting devices
                smartphone.Connect();
                laptop.Connect();
                //Charging devices
                smartphone.Charge(smartphoneChargeTime);
                laptop.Charge(laptopChargeTime);
                //Display Devices
                Console.WriteLine(smartphone.Display());
                Console.WriteLine(laptop.Display());
                Console.WriteLine("Do you want to continue? If yes, hit Y");
                input = Console.ReadLine();
            } while (input.ToUpper() == "Y");
        }
    }
}
