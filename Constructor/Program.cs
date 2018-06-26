using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine("Person name: " + person.Name + " and age: " + person.Age);
            Console.ReadKey();
        }
    }

    class Person
    {

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public Person(int age) : this(age, "")
        {

        }

        public Person() : this(4, "Nick")
        {

        }

        public int Age { get; set; }
        public string Name { get; set; }
    }
}
