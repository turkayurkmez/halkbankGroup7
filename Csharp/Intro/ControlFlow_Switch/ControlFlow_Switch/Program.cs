﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("İşe neyle gitmeyi tercih edersiniz\n1. Taksi\n2.Özel araç\n3. Toplu taşıma");
string answer = Console.ReadLine();
if (answer == "1")
{
    Console.WriteLine("Taksi hızlıdır ama masraflıdır");
}
else if (answer == "2")
{
    Console.WriteLine("Özel araç, kısa vadede hızlı uzun vadede masraflıdır");
}
else if (answer == "3")
{
    Console.WriteLine("Toplu taşıma ucuzdur ancak sinirlerinizi yıpratır");
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız!");
}

switch (answer)
{
    case "1":
        Console.WriteLine("Taksi hızlıdır ama masraflıdır");
        break;
    case "2":
        Console.WriteLine("Özel araç, kısa vadede hızlı uzun vadede masraflıdır");
        break;
    case "3":
        Console.WriteLine("Toplu taşıma ucuzdur ancak sinirlerinizi yıpratır");
        break;
    default:
        Console.WriteLine("Hatalı giriş yaptınız!");
        break;
}



