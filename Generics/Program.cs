using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator<Type>.AreEqual("A", "A");

            if(equal)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }

    public class Calculator <Type>
    {
        public static bool AreEqual(Type value1, Type value2)
        {
            return value1.Equals(value2);
        }
    }
}
