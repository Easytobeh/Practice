using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
          //  a.Print();
            A b = new B();
            b.Print();
        }
    }

  public class A 
    {
        public virtual void Print()
        {
            Console.WriteLine("A implementation");
        }
    }

    public class B : A
    {
       public override void Print()
            
        {
            //base.Print();
            Console.WriteLine("B implementation");
            
        }
        }

    //public class C : B
    //{
    //    public override void Print()
    //    {
    //        base.Print();
    //    }
    //}
}
