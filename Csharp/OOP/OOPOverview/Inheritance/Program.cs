// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

Asci asci = new Asci();
DomatesCorbasi domatesCorbasi = new DomatesCorbasi();
domatesCorbasi.PismeSuresi = 10;
Pirasa pirasa = new Pirasa();
pirasa.PismeSuresi = 15;
//object initializer:
Tulumba tulumba = new Tulumba() { PismeSuresi = 20 };


asci.Pisir(domatesCorbasi);
asci.Pisir(pirasa);
asci.Pisir(tulumba);