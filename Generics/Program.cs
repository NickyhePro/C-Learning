using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<IInterface> box = new Box<IInterface>();
            IInterface i = new MyClass();
            i.Generic = 5;
            box.MyValue = i;
            Console.WriteLine(box.MyValue);

            Console.ReadKey(); 
        }
    }

    class Box<T> where T : IInterface
    {
        public T MyValue { get; set; }
    }

    public interface IInterface
    {
        int Generic { get; set; }
    }

    public class MyClass : IInterface
    {
        public int Generic { get; set; }
    }
}
