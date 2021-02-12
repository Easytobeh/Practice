using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndDerivedClass
{
    class Program
    {
        static void Main(string[] args)
        {
           Parent cc = new Parent();
            
        }
    }

    public class Parent
    {
        string v = "Joh";
        public Parent()
        {
            Console.WriteLine("V: " + v);
        }
        public Parent(string msg, string v)
        {
            Console.WriteLine(msg + v);
        }
        
    }
    
    public class Child : Parent
    {
        public Child()// : base("Parent Child class constructor", " hello.")
        {
            Console.WriteLine("Child class Constructor");
        }
    }

}
