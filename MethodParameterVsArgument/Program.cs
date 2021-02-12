using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameterVsArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[3];
            Num[0] = 101;
            Num[1] = 201;
            Num[2] = 301;

            // ParamsMethods();
            // ParamsMethods(Num);
            ParamsMethods(1,3,2,4);
        }
        public static void ParamsMethods(int x,int y, params int[] Numbers)
        {
            Console.WriteLine("There are {0}", Numbers.Length);
            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }

        }
    }
}
