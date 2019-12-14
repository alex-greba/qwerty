using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace _30._11._2019
{
    [XmlInclude(typeof(Cat))]
    [XmlInclude(typeof(Dog))]
    [Serializable]
    public class Person
    {
        public int UID = -1;
        public string Name;
        public DateTime DofB;
        public Pet Pet;
        public Person() { }
        public Person(string name, DateTime dOfb, Pet pet):this(name, dOfb)
        {
            Pet = pet;
        }
        public Person(string name, DateTime dOfb)
        {
            UID = UID++;
            Name = name;
            DofB = dOfb;
        }
    }
}
