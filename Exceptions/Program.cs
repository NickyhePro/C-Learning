using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                
            }

            using (TextWriter writer = File.CreateText("sample.txt"))     //try-with-source 
            { 
                writer.WriteLine("Hello");
            }

            Console.ReadKey();
        }
    }


}
