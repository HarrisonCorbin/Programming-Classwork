using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegClasses
{
    class Animal
    {
        String Species;
        String Name;
        String color;
        int age;

        public Animal(String Species , String Name, String color)
        {
            this.Species = Species;
            this.Name = Name;
            this.color = color;         
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrrr");
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        public void PrintDescription()
        {
            Console.WriteLine(Name + " is a " + age + " year old, " + color + " " + Species);
        }
    }
}
