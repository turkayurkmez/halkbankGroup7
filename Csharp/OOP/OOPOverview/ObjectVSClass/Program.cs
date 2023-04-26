// See https://aka.ms/new-console-template for more information
using ObjectVSClass;

Console.WriteLine("Hello, World!");

Product p1 = new Product();
p1.Name = "Şapka";
p1.Price = 100;

Product p2 = p1;
p2.Name = "Güneş Gözlüğü";
Console.WriteLine(p1.Name);

byte x = 13;
Product? p3 = new Product();
p3.Name = "Şort";
//if (p3 != null)
//{
//    Console.WriteLine(p3.Name);
//}
Console.WriteLine(p3?.Name);

int? a = null;
Console.WriteLine($"a değişkeni null mu: {a is null}");
//if (a == null)
//{
//    a = 5;
//}
//Console.WriteLine(a);
Console.WriteLine(a ?? 5);
List<int> numbers = null;
//numbers boş ise instance'i al ve 5 sayısını koleksiyona ekle
//if (numbers == numbers)
//{
//    numbers = new List<int>();
//    numbers.Add(5);
//}
(numbers ??= new List<int>()).Add(5);


