using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterfaceExample
{
    public class OurClass : IMyInterface, IMyInterfaceTwo
    {
        //public void Display()
        //{
        //    Console.WriteLine("Displayof IMyInterface");
        //}
        //public void Welcome(string name)
        //{
        //    Console.WriteLine("Welcome to interfaces!!");
        //}
        void IMyInterface.Display()
        {
            Console.WriteLine("Interface One's Display");
        }
        void IMyInterfaceTwo.Display()
        {
            Console.WriteLine("Interface Two's Display");
        }
    }
}
