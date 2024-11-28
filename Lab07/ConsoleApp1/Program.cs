namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Dog();
            Console.WriteLine(animal.Sound);
            animal.Move();

            //Dog dog = new Dog();
            //Console.WriteLine(dog.Sound);
            //dog.Move();

            (animal as IWalkable).Walk();

            Dog dog = new Dog();
            dog.Walk();

            IWalkable walkableDog = new Dog();
            walkableDog.Walk();


            Animal[] animals = new Animal[] { new Cat(), new Dog() };

            foreach (Animal ani in animals)
            {
                Console.WriteLine($"The {ani.GetType().Name} goes {ani.Sound}");
                animal.Move();
            }
        }
    }
}
