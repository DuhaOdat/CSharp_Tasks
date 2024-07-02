using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_2024
{
    internal class Program
    {
        interface ISound
        {
            void MakeSound();
        }

        abstract class Animal
        {
            public string Name { get; set; }

            public Animal(string Name)
            {
                this.Name = Name;
            }
            public abstract void Eat();

            public void Sleep()
            {
                Console.WriteLine($"animal name is {Name} is sleeping");
            }
        }

        class Dog : Animal, ISound
        {
            public Dog(string Name):base(Name) { }
            public override void Eat()
            {
                Console.WriteLine($"animal name is {Name} is eating");
            }

           public void MakeSound()
            {
                Console.WriteLine($" animal name is {Name} and the soud is : Woof1");
            }

        }
        class Cat : Animal, ISound
        {
            public Cat(string Name) : base(Name) { }
            public override void Eat()
            {
                Console.WriteLine($"animal name is {Name} is eating");
            }

          public  void MakeSound()
            {
                Console.WriteLine($" animal name is {Name} and the soud is : Mewo");
            }

        }
        static void Main(string[] args)
        {
            Dog dog = new Dog("ddddd");
            dog.Eat();
            dog.Sleep();
            dog.MakeSound();
            Cat cat = new Cat("ccccc");
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
        }
    }
}
