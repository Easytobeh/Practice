using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Id = 21;

           Console.WriteLine("Student I.D: {0}", std.Id);

            std.Name = "John Doe";
            Console.WriteLine("Student Name: {0}", std.Name);
            Console.WriteLine("Pass Mark: {0}", std.PassMark);

        }
    }

    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        public int MyProperty { get; set; }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Cannot set student ID to Zero or less");
                }
                this._id = Id;
            }
            get
            {
                return this._id;
            }

        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }

        public int PassMark
        {            
            get
            {
                return _passMark;
            }
        }
      

        
    }
}
 