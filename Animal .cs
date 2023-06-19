﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheiratance
{
    internal abstract class Animal
    {
        public string Name;
        public int Age;
        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public abstract  void animalSound();
        public void makesound()
        {
            Console.WriteLine("animal sound");
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

        public override void animalSound()
        {
            throw new NotImplementedException();
        }
        public virtual void doSomthing()
        {
            Console.WriteLine("dog sound");
        }

        public void getAnimalInfo()
        {
            Console.WriteLine(this.Name + " " + this.Age + " " + Breed + " " + Sound);
        }
    }
    internal class cat : Animal
    {
        public cat(string name, int age) : base(name, age)
        {
        }

        public override void animalSound()
        {
            throw new NotImplementedException();
        }
        public void doSomthing() 
        { 
            Console.WriteLine("cat sound");
        }
        public virtual void makesound()
        {
            Console.WriteLine("miaaww!!");
        }
    }
}
