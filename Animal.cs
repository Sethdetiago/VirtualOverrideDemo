using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        public virtual void MakeSound()     //Making a method virtual allows it to be overwritten
        {
            Console.WriteLine("Grrrr");

        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }

        public virtual void Eat()
        {
            //check if animal is hungry
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is eating..."); //if hungry animal will eat
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");//if not simply state not hungry
            }

        }
    }
}
