using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the radius of the circle: ");
            //float radius = float.Parse(Console.ReadLine());

            //Circle C1 = new Circle(radius);
            //float area = C1.CalculateArea();

            //Console.WriteLine("The area of the circle = {0}", area);

            Console.WriteLine(Circle.PI);
            
        }
    }

    class Circle
    {
        public static float PI;
        public float _radius;

        static Circle()
        {
            Console.WriteLine("I am in static constructor");
            Circle.PI = 3.142F;
        }
        public Circle(): this(0) {

        }
        public Circle(float radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return Circle.PI * _radius * _radius;
        }

        //Destructor 
        ~ Circle()
        {

        }
    }
}
