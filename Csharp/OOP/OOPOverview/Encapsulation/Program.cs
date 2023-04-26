// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Product product = new Product();
product.SetPrice(15);
Console.WriteLine(product.GetPrice());

product.Name = "Elma";
product.Description = "Bal gibi Amasya elması";

//double price = 0;
//if (price>0)
//{
//    //product.Price = price;
//}

