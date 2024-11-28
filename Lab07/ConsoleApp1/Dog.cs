using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : Mammal, IWalkable, ISwimmable
    {
        public override string Sound => "Woof";
        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
        public void FetchBall()
        {
            Console.WriteLine("Just throw the ball and I'll fetch it!");
        }

        public void Walk()
        {
            Console.WriteLine("I walk on a leash.");
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
