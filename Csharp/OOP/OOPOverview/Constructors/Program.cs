// See https://aka.ms/new-console-template for more information
using Constructors;

Console.WriteLine("Hello, World!");
Otomobil otomobil = new Otomobil();
Console.WriteLine(otomobil.UretimYili);

Report report = new Report("C:\\sales2023.xslx");
Report rpt2 = new Report("bilmemne.xslx", ReportFormatType.HTML);