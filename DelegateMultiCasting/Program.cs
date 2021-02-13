using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMultiCasting
{
    delegate void SampleDelegate(out int num);
    class Program
    {
        static void Main(string[] args)
        {
            //  SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            //  SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
            //  SampleDelegate del3 = new SampleDelegate(SampleMethodThree);
            //  SampleDelegate del4 = del1 + del2 + del3 - del2;
            //  del4();

            //A different approach

            SampleDelegate del = new SampleDelegate(SampleMethodTwo);
            del += SampleMethodOne;

            var num = 0;
            del(out num);
            Console.WriteLine("Output parameter:{0}", num);
                       

        }

        public static void SampleMethodOne( out int x)
        {
            x = 1;
        }
        public static void SampleMethodTwo(out int x)
        {
            x = 2;
        }
        //public static void SampleMethodThree()
        //{
        //    Console.WriteLine("SampleMethodThree");
        //}
    }
}
