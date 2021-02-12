using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    class Program
    {
        public delegate void HelloMethodDelegate(int Message); 
        static void Main(string[] args)
        {
            HelloMethodDelegate del = new HelloMethodDelegate(HelloMethod);
            var msg = Int32.Parse("H");
            Console.WriteLine(msg);
           // del(msg);
        }

        public static void HelloMethod(int Message)
        {
            Console.WriteLine(Message);

        }
    }
}
