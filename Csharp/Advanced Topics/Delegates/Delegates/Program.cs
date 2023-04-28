// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("Hello, World!");
List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var filterService = new FilterService();
//.NET 1.0
//var oddNumbers = filterService.Filter(numbers, isOdd);
//.NET 2.0
//var evenNumbers = filterService.Filter(numbers, delegate (int x) {  return x % 2==0;  });
//.Net 3+
var bigThenFive = filterService.Filter(numbers, x => x > 5);



//show(bigThenFive);
alternativeShow(bigThenFive);



bool isOdd(int number)
{
    return (number % 2 == 1);
}

void show(List<int> numbers)
{
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
}

void alternativeShow(List<int> numbers)
{
    numbers.ForEach(num => Console.WriteLine(num));
}

