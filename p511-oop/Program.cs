using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop {
  
    
    
    public class Student 
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Introduce() 
        {
            Console.WriteLine($"ПРИВЕТ, меня зовут {firstName} {lastName}, мне {age} лет.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.firstName = "Артём";
            student1.lastName = "Костромин";
            student1.age = 15;

            Student student2 = new Student();
            student2.firstName = "Анатолий";
            student2.lastName = "Костромин";
            student2.age = 20;


            Console.WriteLine("___ Знакомство со студентами ___");
            student1.Introduce();
           
            Console.WriteLine();
            
            student2.Introduce();
           
            Console.ReadKey(); 



        }
    }
}
