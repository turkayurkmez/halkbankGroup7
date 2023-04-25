// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Array'in kaç elemanı saklayacağını biliyorum. Ama elemanları bilmiyorum.
int[] lotto = new int[6];
lotto[0] = 45;
Console.WriteLine(lotto[1]);
//2. Array içinde ne olacağını biliyorum:
string[] seasons = { "Sonbahar", "Kış", "İlkbahar", "Yaz" };
Console.WriteLine(seasons[0]);
Console.WriteLine(seasons[seasons.Length - 1]);

char[] letters = new char[29];

//Kullanıcının girdiği iki basamaklı sayıyı okunuşuna çevirmek istiyoruz:
//93 -> doksan üç


/*
 *  45.656.136
 */
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

Console.WriteLine("İki basamaklı bir sayı giriniz");
int number = Convert.ToInt32(Console.ReadLine());
int birlerBasamagindakiRakam = number % 10;
int onlarBasamagindakiRakam = number / 10;

Console.WriteLine($"{onlar[onlarBasamagindakiRakam]} {birler[birlerBasamagindakiRakam]}");

for (int i = 1; i < 100; i++)
{
    int bir = i % 10;
    int on = i / 10;

    Console.WriteLine($"{onlar[on]} {birler[bir]}");
}
