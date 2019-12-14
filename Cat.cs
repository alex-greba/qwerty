using System;
using System.Collections.Generic;
using System.Text;

namespace _30._11._2019
{
    [Serializable]
    public class Cat : Pet
    {
        public Cat() { }
        public Cat(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Cat " + Name;
        }
    }
}
