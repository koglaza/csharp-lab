
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a list of type int.
            GenericList<int> list1 = new();
            list1.Add(1);

            // Create a list of type string.
            GenericList<string> list2 = new();
            list2.Add("");

            // Create a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new();
            list3.Add(new ExampleClass());

            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World!";
            //strStore.Data = 123; // compile-time error

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            //intStore.Data = "Hello World!"; // compile-time error


            int num = 1;
            string str = "hello";
            Animal obj = new Animal();
            PrettyPrintMyClass(num);
            PrettyPrintMyClass(str);
            PrettyPrintMyClass(obj);



            // Creating a List of integers 
            List<int> mylist = new List<int>();

            // adding items in mylist 
            for (int j = 5; j < 10; j++)
            {
                mylist.Add(j * 3);
            }

            // Displaying items of mylist 
            // by using foreach loop 
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }




            // Creating a Queue 
            Queue myQueue = new Queue();

            // Inserting the elements into the Queue 
            myQueue.Enqueue("C#");
            myQueue.Enqueue("PHP");
            myQueue.Enqueue("Perl");
            myQueue.Enqueue("Java");
            myQueue.Enqueue("C");

            // Displaying the count of elements 
            // contained in the Queue 
            Console.Write("Total number of elements present in the Queue are: ");

            Console.WriteLine(myQueue.Count);

            // Displaying the beginning element of Queue 
            Console.WriteLine("Beginning Item is: " + myQueue.Peek());


        }

        public static void PrettyPrintMyClass<T>(T item)
        {
            Console.WriteLine(">>>>>");
            Console.WriteLine(item);
            Console.WriteLine(">>>>>");
        }
    }
    public class Letter
    {

    }
    public class Email
    {
        
    }
}
