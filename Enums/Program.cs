using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                name = "Mark",
                gender = Gender.Male
            };

            customers[1] = new Customer
            {
                name = "Mary",
                gender = Gender.Female
            };

            customers[2] = new Customer
            {
                name = "Sam",
                gender = Gender.unknown
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Customer name:{0}, gender: {1}", customer.name, GetGender(customer.gender));
            }
           
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.unknown:
                    return "Unknown";

                case Gender.Male:
                    return "Male";

                case Gender.Female:
                    return "Female";

                default:
                    return "Invalid data";
            }
        }
    }

   public enum Gender
    {
        unknown, Male, Female
    }
   public class Customer
    {
        public string name { get; set; }
        public Gender gender { get; set; }
    }
}
