using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    class Program : Custo
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "Daniel"
            };

            Customer c2 = new Customer();
            //c2 = c1;
            Console.WriteLine("C1 Details:\n ID {0}, " +
                "Name: {1}\n C2 Detalis:\n ID {2}, " +
                "Name: {3}", c1.Id, c1.Name, c2.Id, c2.Name);
            c2.Id = 4;
            c2.Name = "Smith";

            Console.WriteLine("C1 Details:\n ID {0}, " +
                "Name: {1}\n", c1.Id, c1.Name);

        }
    }

    public class Customer 
    {
        public int Id { get; set;}
        public string Name { get; set; }

       ~Customer()
        {

        }
    }
}
