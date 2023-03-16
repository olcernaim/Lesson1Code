using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Code
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Pig :Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says : wee, wee");
        }
    }

    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says : hav, hav");
        }
    }
}
