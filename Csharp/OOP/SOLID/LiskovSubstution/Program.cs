// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 *  Liskov diyor ki; Bir X sınıfı, Y sınıfından miras almış ise; X ile Y birbirlerinin yerine kullanılabilir olmalıdır.
 *   İster parametre olarak
 *   İster dönen değer olarak
 *   
 *   Başka bir deyiş ile;
 *   X sınıfı Y'den aldığı özelliklerin DAVRANIŞINI DEĞİŞTİRMEMELİ
 *   
 *   Eğer Miras alan (derived) miras verenden (base) farklı davranıyorsa ihlal ediyorsun demektir.
 
 */

var rect = RectangleFactory.CreateRectangle(3, 10);
Console.WriteLine(rect.GetArea());