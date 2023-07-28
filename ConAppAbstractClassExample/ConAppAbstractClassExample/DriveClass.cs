using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractClassExample
{
    public class DriveClass : OurAb
    {
        string myProp;
        public override string AbProp { get => myProp; set => myProp = value; }
        public override void Welcome(string name)
        {
            Console.WriteLine("Welcome to abstract class " + name);
        }
    }
}
