// See https://aka.ms/new-console-template for more information
using GenericTypes;

Console.WriteLine("Hello, World!");
GenericPoint<double> genericPoint = new GenericPoint<double>();

int x = 1;
int y = 2;
Console.WriteLine($"Önce: x={x} ve y={y}");
Swap<int>(ref x, ref y);
Console.WriteLine($"Sonra: x={x} ve y={y}");





void Swap<T>(ref T left, ref T right) where T : IComparable<T>
{
    T temp;
    if (left.CompareTo(right) > 0)
    {
        temp = left;
        left = right;
        right = temp;

    }

}