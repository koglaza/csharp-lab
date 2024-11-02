double QuadraticEquation(double x, double a, double b, double c)
{
    return 0.0;
}


void Swap(double a, double b)
{
    double temp = a;
    a = b;
    b = temp;
}
double x = 10;
double y = 20;
Swap(x, y);
Console.WriteLine($"x = {x}, y = {y}");


double Multiply(double a, double b)
{
    return a * b;
}

void PrintDayOfTheWeek(DayOfTheWeek day)
{
    Console.WriteLine(day);
}
PrintDayOfTheWeek(DayOfTheWeek.Monday);


string itemName = "eggplant";
DateTime date = DateTime.Now;
decimal price = 1.99m;
Unit unit = Unit.item;
Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");


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