using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheiratance
{
    internal class Animal
    {
        public string Name;
        public int Age;
        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    internal class Dog : Animal
    {
        string Breed;
        string Sound;

        public Dog(string name, int age, string Breed, string Sound) : base(name, age)
        {
            this.Breed = Breed;
            this.Sound = Sound;
        }
        public void getAnimalInfo()
        {
            Console.WriteLine(this.Name + " " + this.Age + " " + Breed + " " + Sound);
        }
    }
}
