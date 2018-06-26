using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullable = null;
            nullable = 8;
            Console.WriteLine(nullable);
            Console.ReadKey();
        }
    }
}
