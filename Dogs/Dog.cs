using System;
using System.Collections.Generic;
using System.Text;

namespace Dogs
{
    class Dog
    {
        public Dog()            // default constructor
        {
            Name = "Bau";
        }
        public Dog(string name, string breed, int age)      // constructor!
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Hey from dog!");
            Console.WriteLine($"My name is {Name} Breed: {Breed}");
            Console.WriteLine("Bye");
        }
    }
}
