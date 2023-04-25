// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> words = new List<string>() { "ayna", "berrak", "monitör" };
//int index = 0;
//while (index < words.Count)
//{
//    Console.WriteLine(words[index++]);
//}

for (int index = 0; index < words.Count; index++)
{
    Console.WriteLine(words[index]);
}

Console.WriteLine("Bir kelime giriniz:");
string word = Console.ReadLine();
//girilen kelime, kelime listesinde var mı yok mu anlaşılsın?

bool isExists = false;
int findingIndex = 0;
for (int i = 0; i < words.Count; i++)
{
    if (words[i] == word)
    {
        isExists = true;
        findingIndex = i;
        break;
    }

}

if (!isExists)
{
    Console.WriteLine($"{word} kelimesi listede yer almıyor!");
}
else
{
    Console.WriteLine($"{word} kelimesi listede {findingIndex}. indeksinde yer alıyor!");
}


