using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop {
    class animal 
    {
        protected string Name { get; set; }
       
        public animal(string name) 
        {
            Name = name;
        }

        public virtual void eat() 
       {
            Console.WriteLine("животное ест");
       }
    }
    class Dog : animal
    {
       public Dog(string name):base(name) { }
        public override void eat() 
        {
            Console.WriteLine($"{Name}(кушает корм)");
        }
    }

    class Cat : animal {
        public Cat (string name) : base(name) { }
        public override void eat() 
        {
            Console.WriteLine($"{Name}(лежит на диване)");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("bob");
            dog.eat();
            Cat cat = new Cat("tom");
            cat.eat();
            Console.ReadKey(); 
        }
    }
}
