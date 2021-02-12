using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
   class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer p = new Program();

        }

        public override void Print()
        {

        }
    }

    public abstract class Customer
    {
        public abstract void Print();
    }

    
}
