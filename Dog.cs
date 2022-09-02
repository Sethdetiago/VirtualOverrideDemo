using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Dog : Animal
    {

        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            //Eats the same way other animals do
            base.Eat();

        }
        public override void MakeSound()
        {
            //Overriding to make a dog noise 
            Console.WriteLine("Woof Woof");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine($"{Name} does not want to play right now");
            }
        }
    }
}
