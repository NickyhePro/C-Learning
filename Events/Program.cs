using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Rooster rooster = new Rooster();
            rooster.DoCaw();
            rooster.Caw += person.GetUp;
            rooster.DoCaw();

            Console.ReadKey();
        }

        class Rooster
        {
            private Action caw;
            public event Action Caw
            {
                add
                {
                    if (caw == null)
                        caw += value;
                }
                remove
                {
                    if (caw != null)
                        caw -= value;
                }
            }

            public void DoCaw()
            {
                if (caw == null)
                {
                    Console.WriteLine("Null");
                }
                else
                {
                    caw();
                }
                
            }
        }

        class Person
        {
            public void GetUp()
            {
                Console.WriteLine("I'm up");
            }
        }
    }
}
