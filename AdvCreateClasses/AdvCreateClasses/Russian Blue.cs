using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Russian_Blue
    {

        String name;
        String species;

        public Russian_Blue(string name)
        {
            species = "cat";
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Hisss");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrr");
            SeeLaser();
        }

        public void SeeLaser()
        {
            Console.WriteLine("*cat pounces*");
        }
    }
}
