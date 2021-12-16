using System;

namespace GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.FirstName);

            person.FirstName = "Pesho";
            person.FirstName = "Ceko";
            person.LastName = "Petrov";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.FullName);

        }
    }
}
