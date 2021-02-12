using System;
using NSa = Team.A;
using NSb = Team.B;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        NSa.ClassA.Print();
        NSb.ClassA.Print();
        }
    }
 
namespace Team
{
    namespace A
    {
        class ClassA
    {
        public static void Print()
        {
            Console.WriteLine("I am Class A");
        }

    }
}

}

namespace Team
{
    namespace B
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("I am Class B");
            }
        }
    }
}