using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { FirstName = "John", LastName = "Doe" };
            Person p2 = new Person() { FirstName = "Jane", LastName = "Doe", BirthDate = new DateTime(1999, 5, 11) };
            Person p3 = new Person() { FirstName = "Jill", LastName = "Doe", BirthDate = new DateTime(2001, 2, 4), EmailAddress = "jill@gmail.com" };
            Person child = Person.NewlyBornChild;
            child.FirstName = "Brian";
            child.LastName = "Doe";

            Person p4 = null;
            if (p4 is null)
            {
                Console.WriteLine("Person is null");
            }
            else
            {
                Console.WriteLine($"Name = {p4.GetFullName()}");
            }
            Console.WriteLine(p4 is null ? "Person is null" : $"Name = {p4.GetFullName()}");
            Console.WriteLine((p4 ?? new Person("N", "N")).GetFullName());
        }
    }
}
