using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\OloruntobiJunaid\Documents\The Fellowship\.Net\C#.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                Console.WriteLine(streamReader.ReadToEnd());
               
            }
            catch (UnauthorizedAccessException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please check if: " + ex.FileName + " exist");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Problem: {ex.Message}");
            }

            finally
            {
                streamReader.Close(); 
                Console.WriteLine("Finally block");
            }
        }
    }
}
