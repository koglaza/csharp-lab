using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Mammal, IWalkable
    {
        public override string Sound => "Meow";
        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }

        public void Walk()
        {
            Console.WriteLine("I like walking on furniture and tables");
        }
    }
}
