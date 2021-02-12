using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingVsHiding
{
    class Program
    {
        static void Main(string[] args)
        {
           BaseClass B = new DerivedClass();
            B.Print();
        }
    }

public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a base class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
           // base.Print(); 
            Console.WriteLine("I am derived class");
        }
    }
}
