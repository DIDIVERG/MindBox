using System.Xml;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes;

public class Triangle : IShape
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public double Area()
    {
        double p = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
    }
    // comparison with 1e-10 used to avoid accuracy losing when compare two floating point numbers. 
    public bool IsRightAngled()
    {
        double[] sides = { _side1, _side2, _side3 };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < 1e-10;
    }
}
