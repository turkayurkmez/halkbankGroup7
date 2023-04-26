// See https://aka.ms/new-console-template for more information
using functionOverloadingAndOptional;

Console.WriteLine("Hello, World!");
Geometry geometry = new Geometry();
var rectangle = geometry.GetArea(3, 10, "Dikdörtgen");
Console.WriteLine(rectangle);
var circle = geometry.GetArea(3, "Daire");
Console.WriteLine(circle);

var optCircle = geometry.OptionalGetArea(3, shape: "Daire");
var optTriangle = geometry.OptionalGetArea(5, 6, "Üçgen");
var optSquare = geometry.OptionalGetArea(3);
var opRect = geometry.OptionalGetArea(unit1: 3, shape: "Dikdörtgen", unit2: 6);

