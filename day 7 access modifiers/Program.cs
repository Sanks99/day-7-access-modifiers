using System;

namespace AccessModifierExample
{
    public class Person
    {
        
        public string Name { get; private set; }

       
        private int age;

       
        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

       
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {age} years old.");
        }

       
        private void HaveBirthday()
        {
            age++;
            Console.WriteLine("Happy Birthday!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Sankalpa", 24);

            person.Introduce();
            
        }
    }
}