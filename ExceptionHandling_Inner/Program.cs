using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling_Inner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first Number:");
                    var firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second Number:");
                    var secondNumber = Convert.ToInt32(Console.ReadLine());

                    int result = firstNumber / secondNumber;

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\OloruntobiJunaid\Documents\The Bulb Fellowship\.Net";

                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine(ex.Message);
                    }

                    else
                        throw new FileNotFoundException($"File at: {filePath} could not be found", ex);

                }

            }
            catch(Exception exception)
            {
                Console.WriteLine($"current exception: {exception.GetType().Name}");
                Console.WriteLine($"Inner Exception: {exception.InnerException.GetType().Name}");
            }
            
        }

    }
}
