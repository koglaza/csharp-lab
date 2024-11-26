using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public abstract string Sound { get; }
        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }
    }
    public class Cat : Animal
    {
        public override string Sound => "Meow";
        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
    }

    public class Dog : Animal
    {
        public override string Sound => "Woof";

        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
    }

}
