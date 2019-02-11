using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Animal
    {
        String species;
        String name;

        public Animal(String species, String name)
        {
            this.species = species;
            this.name = name;
            
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrrr");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
