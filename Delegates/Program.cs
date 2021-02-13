using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    class Program
    {
        public delegate void HelloMethodDelegate(string Message); 
        static void Main(string[] args)
        {
            HelloMethodDelegate del = new HelloMethodDelegate(HelloMethod);
           del("Hello");
        }

        public static void HelloMethod(string Message)
        {
            Console.WriteLine(Message);

        }
    }
}
