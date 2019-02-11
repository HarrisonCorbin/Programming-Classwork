﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCreateClasses
{
    class Dog
    {
        String name;
        String species;
        bool dockedTail;

        public Dog(String species, String name,bool dockedTail)
        {
            this.species = "dog";
            this.name = name;
            this.dockedTail = dockedTail;
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void PlayFetch()
        {
            Console.WriteLine("*chases ball 5 times then quits*");
        }

        public bool getDockedTail()
        {
            return dockedTail;
        }
    }
}
