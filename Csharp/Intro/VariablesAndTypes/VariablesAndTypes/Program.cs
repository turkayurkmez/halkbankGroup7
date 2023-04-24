// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Sözel
 * Mantıksal
 * Sayısal
 * 
 */

//Sayısal Tipler
//0544 211 12 13
//Tam sayılar:
byte minimumValue = 0;
sbyte signedByte = -13;

short minimumShort = -15;

ushort unSignedShort = 65535;

//int, uint, long, ulong
double pi = 3.14;

float floatPi = 3.14f;
decimal decimalPi = 3.145913001123456452056555445646545566550556545455444445544004400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005544456559M;

//Sözel:
/*
 * char ve string
 */

char letter = 'A';
char symbol = '?';

string name = "Türkay Ürkmez";
//int age = 43;
Console.WriteLine(name);
//Console.WriteLine($"{name} isimli kişi, {age} yaşında");

Console.WriteLine("Doğum yılınızı giriniz:");
try
{
    int birthYear = int.Parse(Console.ReadLine());
    //int birthYear2 = Convert.ToInt32(Console.ReadLine());
    int age = DateTime.Now.Year - birthYear;
    Console.WriteLine($"Girdiğiniz yıla göre yaşınız: {age}");
}
catch (FormatException)
{
    Console.WriteLine("Sadece sayısal değer giriniz");

}

Console.WriteLine($"int tipininin minimum değeri: {int.MinValue}, maksimum değeri ise: {int.MaxValue}, varsayılan değeri ise {default(int)} değeridir. ");



