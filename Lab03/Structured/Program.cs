#region LOOPS
// zadanie 1
//int i = 10;
//do
//{
//    Console.WriteLine(i);
//    i--;
//} while (i >= 0);

// zadanie 2
//string password = "";
//do
//{
//    Console.WriteLine("Podaj hasło:");
//    password = Console.ReadLine();
//} while (password != "koniec");

// zadanie 3
int j = 1;
Console.WriteLine("Liczby parzyste:");
while (j <= 100)
{
    if (j % 2 == 0)
        Console.WriteLine(j);
    j++;
}
// zadanie 4A
for (int i = 1; i <= 15; i++)
    Console.WriteLine($"Square of {i} equals {i * i}");
// Zadanie 4B
for (int i = 1; i <= 15; i++)
{
    string txt = "Square of " + i + " equals " + i * i;
}
// zadanie 5
// zadanie 6
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
Console.WriteLine("Dzielniki 7:");
foreach (int i in numbers)
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
        break;
    }
}
#endregion

#region ARRAYS
// zadanie 7
double[] dArray = new double[20];
for (int i = 0; i < 20; i++)
{
    dArray[i] = Math.Sqrt(i);
    Console.WriteLine("i: " + dArray[i]);
}

// zadanie 8
// deklaracja tablicy dwuwymiarowej
int[,] m = new int[3, 4];
// wypelnienie danymi
for (int column = 0; column < 3; column++)
{
    for (int row = 0; row < 4; row++)
    {
        // wypelnienie liczba calkowita np. column+row
        m[column, row] = column + row;
    }
}
// transpozycja
int[,] t = new int[4, 3];
for (int column = 0; column < 3; column++)
{
    for (int row = 0; row < 4; row++)
    {
        t[row, column] = m[column, row];
    }
}
#endregion

#region FUNCTIONS_EXAMPLES
PrintNewLine();
PrintIfNotEmpty("");
int maxVal = GetIntMaxValue();
double square = CalculateSquare(5.0);
double cube = CalculateCube(4.0);

void PrintNewLine()
{
    Console.WriteLine();
}
void PrintIfNotEmpty(string textToPrint)
{
    if (string.IsNullOrEmpty(textToPrint))
        return;
    Console.WriteLine(textToPrint);
}
int GetIntMaxValue()
{
    return Int32.MaxValue;
}
double CalculateSquare(double parameter)
{
    return parameter * parameter;
}
double CalculateCube(double parameter)
{
    return parameter * CalculateSquare(parameter);
}
#endregion

#region FUNCTIONS
// zadanie 10
void PrintUpperCase(string txt)
{
    Console.WriteLine(txt.ToUpper());
}
PrintUpperCase("Tekst do druku");

// zadanie 11
void CreateAndPrintMatrix(int x, int y)
{
    // stworz macierz
    char[,] matrix = new char[x, y];

    // wypelnij macierz
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = '#';
        }

    }
    // wydrukuj macierz
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}
CreateAndPrintMatrix(10,10);

// zadanie 12
string EvenOrOdd1(int toCheck)
{
    string retStr = "";
    if (toCheck % 2 == 0)
    {
        retStr = "Even";
    }
    else
    {
        retStr = "Odd";
    }
    return retStr;
}
string EvenOrOdd2(int toCheck)
{
    if (toCheck % 2 == 0)
        return "Even";
    else
        return "Odd";
}
string EvenOrOdd3(int toCheck)
{
    return toCheck % 2 == 0 ? "Even" : "Odd";
}

// zadanie 13
void PrintConsoleSquare(int x, int y)
{
    // rysuj gorna krawedz - pierwszy wiersz
    for (int i = 0; i < x; i++)
        Console.Write("$");

    // zejdz do nowej linii
    Console.WriteLine();

    // rysuj srodek (boki) - dla kazdego wiersza
    for (int i = 0; i < y - 2; i++)
    {
        // rysuj lewy bok
        Console.Write("$");

        // teraz drukuj puste miejsce
        for (int j = 0; j < x - 2; j++)
        {
            Console.Write(" ");
        }

        // rysuj prawy bok
        Console.Write("$");
        // zejdz do nowej linii
        Console.WriteLine();
    }
    // rysuj dolna krawedz - ostatni wiersz
    for (int i = 0; i < x; i++)
        Console.Write("$");
}
PrintConsoleSquare(15, 15);


// zadanie 14

 double[] QuadricFun(int a, int b, int c)
{

    //   AX2 + BX + c = 0
    // tutaj wyliczanie delty i wynikow
    return new double[2];
}

#endregion