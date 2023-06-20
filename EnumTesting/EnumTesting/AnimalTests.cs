using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTesting
{
    internal class AnimalTests
    {
        public void Foo()
        {
            List<Dog> dogs = new List<Dog>();

            // List<Animal> animals = dogs; //Illegal as List has methods that would cause issues with different types list of dogs, becomes list of dogs + camel for example.
            // animal.Add(new Camel());

            IEnumerable<Animal> animals2 = dogs;
            foreach (Animal animal in animals2)
            {
                animal.Feed();
            }

            IEnumerable<Dog> dogArray = new[] { new Dog() };
            IEnumerable<Animal> animalArray = dogArray;

            foreach (Animal animal in animalArray)
            {
                animal.Feed();
            }
        }
    }

    internal class Animal
    {
        public void Feed()
        { }
    }

    internal class Dog : Animal
    {
        public void Woof()
        { }
    }
}
