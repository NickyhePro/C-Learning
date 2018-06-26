using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        private delegate void MyDelegate();

        static void Main(string[] args)
        {
            var action = new Action<string>(Print);
            action.Invoke("World");

            var func = new Func<int, double>(Cal);
            var x = func.Invoke(5);
            Console.WriteLine(x);

            Console.ReadKey();
        }

        private static double Cal(int i)
        {
            return i + 5;
        }

        private static void Print(String s)
        {
            Console.WriteLine("Hello "+s);
        }
    }
}
