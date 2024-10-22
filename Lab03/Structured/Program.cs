#region LOOPS
// zadanie 1

// zadanie 2

// zadanie 3

// zadanie 4

// zadanie 5
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

// zadanie 6

#endregion

#region ARRAYS

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

#endregion