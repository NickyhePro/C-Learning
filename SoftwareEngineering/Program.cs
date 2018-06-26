using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance1 = new Distance();
            var distance2 = new Distance();
            var distance3 = distance1 + distance2;

            Console.WriteLine(distance3.Meters+" meters, "+distance3.Miles+" miles.");
            
            Console.ReadKey();
        }
    }

}
