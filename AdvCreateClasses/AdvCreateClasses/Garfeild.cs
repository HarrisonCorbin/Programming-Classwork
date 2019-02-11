using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Garfeild
    {
        String name;
        String species;
       

        public  Garfeild()
        {
            this.species = " Cat";
            this.name = "Garfeild";
        }

        public void MakeSound()
        {
            Console.WriteLine("mmmm, lasagna");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            LayOnLap();
            Console.WriteLine("*takes a nap*");
        }

        public void LayOnLap()
        {
            Console.WriteLine("*cuddles on owner's lap*");
        }


        public void SeeLaser()
        {
            BeHappy();
        }
    }
}
