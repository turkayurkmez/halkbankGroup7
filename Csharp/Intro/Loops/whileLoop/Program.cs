// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> words = new List<string>() { "ayna", "berrak", "monitör" };

//Console.WriteLine(words[0]);
//Console.WriteLine(words[1]);
//Console.WriteLine(words[2]);

//bir sayı olsun
//bu sayı, words koleksiyonunun eleman sayısından küçük ise
//Ekranda bu sayıya karşılık gelen kelimeyi göster
//Sayıyı 1 arttır

int index = 0;
//islem: Console.WriteLine(words[index++]);
//if (index < words.Count)
//{
//    goto islem;
//}

while (index < words.Count)
{
    Console.WriteLine(words[index++]);
}



