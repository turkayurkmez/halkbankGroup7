// See https://aka.ms/new-console-template for more information
using AbstractANDInterface;
using System.Net.Sockets;

Console.WriteLine("Hello, World!");
Stream stream = new MemoryStream();

FileStream fileStream = null;

MemoryStream memoryStream = null;
NetworkStream networkStream = null;


ExcelDocument excel = new ExcelDocument();
WordDocument wordDocument = new WordDocument();
PDFDocument pDFDocument = new PDFDocument();

PrintComponent component = new PrintComponent();
component.Print(excel);
component.Print(wordDocument);

