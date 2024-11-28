using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Salmon : Animal, ISwimmable
    {
        public override string Sound => "Glub";

        public void Swim()
        {
            Console.WriteLine("I can swim really fast");
        }
    }
}
