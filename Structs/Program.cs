using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)

        {
            Customer C1 = new Customer(1, "Doe");
            C1.PrintCustomerData();

            Customer C2 = new Customer();
            C2.Id = 2;
            C2.Name = "John";            
            C2.PrintCustomerData();

            
            Customer C3 = new Customer
            {
                Id = 3, Name = "Smith"
            };
            C3.PrintCustomerData();


        }

        public struct Customer
        {
            private int _id;
            private string _name;

            
            public Customer(int id, string name) 
            {
                this._id = id;
                this._name = name;

            }

            public int Id
            {
                get => this._id;
                set => this._id = value; 
            }

            public string Name 
            {   
                get => this._name; 
                set => this._name = value; 
            }

            public void PrintCustomerData()
            {
                Console.WriteLine("Customer details:\n Name: {0}\n ID: {1}", this._name, this._id);
            }

        }


    }

   
      
}
