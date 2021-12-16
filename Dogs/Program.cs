using System;

namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog.Bark();
            Dog.AverageLife = 20;

            Dog dog1 = new Dog("Sharo", "Pitbull", 3); // with constructor
            //{
            //    Name = "Sharo",
            //    Age = 2,
            //    Breed = "Pitbull"
            //};
            Dog dog2 = new Dog("Ronny", "Street", 2);
            //{
            //    Name = "Ronny",
            //    Age = 2,
            //    Breed = "Street"
            //};

            //dog.Name = "Sharo";
            //dog.Age = 2;
            Dog dog3 = new Dog();
            //Console.WriteLine(dog.Name);
            //Console.WriteLine(dog.Breed);
            dog1.SayHi();
            dog2.SayHi();
            dog3.SayHi();
        }
    }
}
