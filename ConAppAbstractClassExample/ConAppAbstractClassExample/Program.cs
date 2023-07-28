using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurAb ourAb = new OurAb();
            //Error, cannot create object of abstract class
            DriveClass obj = new DriveClass();
            obj.Welcome("Sam");
            obj.Display();
            Console.ReadKey();
        }
    }
}
