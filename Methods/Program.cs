using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();// ("John", "Smith");
            C1.PrintFullName();
            Customer C2 = new Customer("John", "Doe");
            C2.PrintFullName();
        }
    }

    class Customer
    {
        string _firstName, _lastName;

        public Customer() : this("No First name", "No Last Name")
        {

        }
         public Customer (string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full name = {_firstName} {_lastName}");
        }
        ~Customer()
        {

        }
    }
}
