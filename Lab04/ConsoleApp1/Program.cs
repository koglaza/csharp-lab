using ConsoleApp1;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(QuadraticEquation());
            Console.WriteLine(QuadraticEquation(1.0, 2.5, 3.2, 4.999));

            double x = 10;
            double y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            Multiply(1.0, 2.0);
            Multiply(1.0, 2.0, 3.0);
            Multiply(1.0, 2.0, 3.0, 4.0, 5.0);

            PrintDayOfTheWeek(DayOfTheWeek.Monday);


            string itemName = "eggplant";
            DateTime date = DateTime.Now;
            decimal price = 1.99m;
            Unit unit = Unit.item;
            Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");

        }

        static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
        {
            return a * x * x + b * x + c;
        }
        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        static double Multiply(params double[] a)
        {
            double result = 1.0;
            foreach (double x in a)
            { result *= x; }
            return result;
        }
        static void PrintDayOfTheWeek(DayOfTheWeek day)
        {
            Console.WriteLine(day);
        }
        bool CheckTheAge(int age)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException("Age can not be a negative number!");
            if (age >= 18)
                return true;
            else
                return false;
        }
        enum DayOfTheWeek
        {
            Monday
        }

        enum Unit { item, kilogram, gram, dozen };
    }
}




















