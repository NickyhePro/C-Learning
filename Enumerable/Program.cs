using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] s = { 1, 2, 3, 4, 5, 6 };
            s.Take(3).ToList().ForEach(Console.WriteLine);
            foreach (var x in s.Skip(2).Where(i => i % 2 == 0))
            {
                Console.WriteLine(x);
            }

            var list = NumberLoop().Take(10).Where(i => i % 2 != 0).Reverse().ToList();
            Console.WriteLine("Odd numbers");
            list.ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        private static IEnumerable<int> NumberLoop()
        {
            int i = 0;
            while (true)
            {
                yield return i++;
            }
        }
    }
}
