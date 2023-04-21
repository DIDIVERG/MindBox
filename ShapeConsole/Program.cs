// See https://aka.ms/new-console-template for more information
using ShapeLib.Interfaces;
using ShapeLib.Shapes;


IShape[] shapes = new IShape[]
{
    new Circle(5),
    new Triangle(3,4,5)
};

foreach (var item in shapes)
{
    Console.WriteLine(item.Area());
}