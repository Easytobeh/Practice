using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   interface ICustomer
    {
       void PrintCustomer();
    }

   interface IStudents : ICustomer
    {
        void PrintStudents();
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //c1.PrintCustomer();

            IStudents name = new Customer();
        }
    }

    public class Customer : IStudents
    {
        public void PrintCustomer()
        {
            Console.WriteLine("Interface Print Method");
        }

        public void PrintStudents()
        {
            Console.WriteLine("Students Interface Method");
        }
    }

    
}
