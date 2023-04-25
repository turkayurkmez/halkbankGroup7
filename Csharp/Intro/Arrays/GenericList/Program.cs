// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
ArrayList list = new ArrayList();

//boxing: Bir object tipine değer atama.
//unboxing: Bir object içindeki değeri gerçek değerine dönüştürme.


//boxing:
list.Add("Türkay");
//boxing:
list.Add(43);
//unboxing:
//int name = (int)list[0];

List<string> names = new List<string>();
names.Add("Özkan");
names.Add("Esma");

//List<Product> products = new List<Product>();
//products.Add(new Product { Name = "asas", Price = 15.4 });

//Console.WriteLine(name);