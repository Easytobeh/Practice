using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();


        }
    }

    interface IA
    {
        void AMethod();
        
    }
    interface IB
    {
        void BMethod();
    }

    interface IAB : IA, IB 
    {

    }

    public class A : IA
    { 
        public void AMethod()
        {
            Console.WriteLine("This is A method");
        }
}
    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("This is B method");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }

       
    }


}
