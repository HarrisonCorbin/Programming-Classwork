using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Corgi","Ein","Tan");
            myAnimal.MakeSound();
            myAnimal.SetAge(5);
            myAnimal.PrintDescription();
            Console.ReadLine();
        }

      
      
    }
}

