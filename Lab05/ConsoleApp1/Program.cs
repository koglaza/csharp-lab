using ConsoleApp1;

#region structs
Coords point1 = new Coords(1.0, 1.0);
Console.WriteLine(point1);

Coords point2 = new Coords(1.0, 1.0); ;

if (point1.Equals(point2))
    Console.WriteLine("Equal structs");
else
    Console.WriteLine("Different structs");

point1 = new Coords(1.0, 1.0);
point2 = new Coords(2.0, 2.0);
Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");

#endregion

#region tuples
(double, int) t1 = (4.5, 3);
Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
Console.WriteLine(t1.ToString());
Console.WriteLine($"Hash code of {t1} is {t1.GetHashCode()}.");
// Output:
// Tuple with elements 4.5 and 3.
// (4.5, 3)
// Hash code of (4.5, 3) is 718460086.


(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
var t3 = (Sum: 4.5, Count: 3);
Console.WriteLine($"Sum of {t3.Count} elements is {t3.Sum}.");
// Output:
// Sum of 3 elements is 4.5.

(double Sqrt, double Log)[] results = new (double Sqrt, double Log)[20];
for (int i = 0; i < 20; i++)
{
    results[i] = (Math.Sqrt(i), Math.Log(i));
}
for (int i = 0; i < 20; i++)
    Console.WriteLine($"int={i + 1} sqrt()={results[i].Sqrt} log()={results[i].Log}");

#endregion


#region classes
Person person1 = new Person("John", "Doe");
Console.WriteLine($"Person={person1.FirstName} {person1.LastName}");
#endregion




