// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string answer = string.Empty;
do
{
    Console.WriteLine("Çıkmak için q'ye basınız");
} while (Console.ReadLine() != "q");

int value = 0;
bool isNumber = false;
do
{
    Console.WriteLine("Bir sayı giriniz");
    isNumber = int.TryParse(Console.ReadLine(), out value);
} while (!isNumber);


