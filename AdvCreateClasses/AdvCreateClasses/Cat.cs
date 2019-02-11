using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Cat
    {
        String name;
        String species;
       

        public  Cat(String species, String name)
        {
            this.species = " Cat";
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrr");
            MakeSound();
            SeeLaser();
        }

        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}
