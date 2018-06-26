using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>() {1,2,3,4,5};

            foreach (var i in list.Where(i => i % 2 == 0))
            {
                Console.WriteLine(i);
            }

            IList<int> oddNums = list.Where(i => i % 2 != 0).ToList();
            foreach (var i in oddNums)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
