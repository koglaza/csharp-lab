namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Cat(), new Dog() };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
                animal.Move();
            }
        }
    }
}
