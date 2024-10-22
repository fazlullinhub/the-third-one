using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.Sound();
            myCat.Sound();
        }
    }
}
