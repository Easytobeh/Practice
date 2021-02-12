using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    interface ICustomer
    {
        void InterfaceMethod();
    }

    interface IStudent
    {
        void InterfaceMethod();
    }
    class Program : ICustomer, IStudent
    {
        static void Main(string[] args)
        {
          Program p = new Program();
            p.InterfaceMethod();
            //((IStudent)p).InterfaceMethod();
            //((ICustomer)p).InterfaceMethod();
        }

     public void InterfaceMethod()
        {
            Console.WriteLine("Customer Interface Method");
        }

        void IStudent.InterfaceMethod()
        {
            Console.WriteLine("Student Interface Method");
        }
    }
}
