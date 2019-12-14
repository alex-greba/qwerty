using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _30._11._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Go!");
            List<Person> person = new List<Person>();

            person.Add(new Person("John", new DateTime(2001, 1, 1), new Cat("Kissen")));
            person.Add(new Person("Vasya", new DateTime(2002, 2, 2), new Dog("Gawwy")));
            person.Add(new Person("Alexander", new DateTime(2003, 3, 3), new Cat("Disney")));
            person.Add(new Person("Marya", new DateTime(2004, 4, 4), new Dog("Hrum")));
            person.Add(new Person("Lena", new DateTime(2005, 5, 5)));

            BinaryFormatter f = new BinaryFormatter();

            using (FileStream fs = new FileStream(ConfigurationManager.AppSettings["MyFileName"], FileMode.OpenOrCreate))
            {
                f.Serialize(fs, person);
                fs.Close();
            }

            using (FileStream fs = new FileStream(ConfigurationManager.AppSettings["MyFileName"], FileMode.OpenOrCreate))
            {
                List<Person> newPersonList = (List<Person>)f.Deserialize(fs);
                foreach (Person newPerson in newPersonList)
                {
                    Console.WriteLine($"Name: {newPerson.Name}" +
                        $" _ Date of Birth: {newPerson.DofB.ToShortDateString()}" +
                        $" _ Pet: {newPerson.Pet?.ToString() ?? "Нет"}");/**/
                }

            }
            Console.WriteLine("Ok!");

            var text = Resource.BigText;
            Console.WriteLine(text);


        }
    }
}
