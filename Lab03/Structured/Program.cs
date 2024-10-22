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

List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };