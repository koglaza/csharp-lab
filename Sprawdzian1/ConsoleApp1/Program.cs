namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            // tutaj rozwiązanie zadania 1

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

            // tutaj rozwiązanie zadania 3
            string finalText="";
            Console.WriteLine(finalText);

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");

            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

    }
}
