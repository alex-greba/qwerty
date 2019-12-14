using System;
using System.Collections.Generic;
using System.Text;

namespace _30._11._2019
{
    [Serializable]
    public class Dog : Pet
    {
        public Dog() { }
        public Dog(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Dog " + Name;
        }
    }
}
