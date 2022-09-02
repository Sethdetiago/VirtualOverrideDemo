using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Fido", 3);
            puppy.MakeSound();  //woof woof

            puppy.Eat();        //fido is eating

            puppy.Play();       //fido is playing

            puppy.IsHappy = false;

            puppy.Play();       //Fido does not want to play right now

            Console.ReadKey();

        }
    }
}
