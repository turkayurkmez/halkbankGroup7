// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kilonuzu giriniz");
int weight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Boyunuzu, metre cinsinden giriniz");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = weight / (height * height);

string state = "";
double idealWeight = 24.89 * (height * height);
if (bmi < 18.5)
{
    state = "Zayıf";
}
else if (bmi > 18.4 && bmi < 24.9)
{
    state = "Sağlıklı kilo";
}
else if (bmi < 29.9)
{
    state = "Kilolu";
}
else
{

    state = "Obez!!";
}


Console.WriteLine($"Bmi değeriniz: {bmi}. Buna göre sizin durumunuz: {state}. İdeal kilonuz:{idealWeight} ");

Console.WriteLine("Hangi aydasınız (Ayın ismini girin. Örnek olarak: Ocak)");
string month = Console.ReadLine();
if (month == "Aralık" || month == "Ocak" || month == "Şubat")
{
    Console.WriteLine("Kış");
}
else if (month == "Mart" || month == "Nisan" || month == "Mayis")
{
    Console.WriteLine("İlk bahar");
}

Console.WriteLine("Bir sayı giriniz");
int value = Convert.ToInt32(Console.ReadLine());
//string valueState = "";
//if (value % 2 == 0)
//{
//    valueState = "çifttir";
//}
//else
//{
//    valueState = "tektir";
//}
//ternary operatör:
string valueState = value % 2 == 0 ? "Çifttir" : "tektir";

Console.WriteLine($"{value} değeri, {valueState}");

//Pattern matching:
object o = 15;

if (o is int intValue)
{
    Console.WriteLine($"{intValue} değerinin karesi: {intValue * intValue}");
    Console.WriteLine("int değeri " + intValue.ToString());
}
else
{
    Console.WriteLine("o değişkeninin içinde int yok!");
}


