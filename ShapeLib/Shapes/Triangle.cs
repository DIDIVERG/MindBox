using System.ComponentModel;
using System.Xml;
using ShapeLib.Exceptions;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes;

public class Triangle : Shape
{
    
    public Triangle(List<Point> points) : base(points)
    {
        if (points.Count != 3)
        {
            throw new PointsQuantityException($"Points quantity must be 3 but this is {points.Count}");
        }
        CreateLines();
        ValidateTriangle();
    }

    public Triangle(List<Line> lines) : base(lines)
    {
        if (lines.Count != 3)
        {
            throw new LinesQuantityException($"Lines quantity must be 3 but this is {lines.Count}");
        }
        ValidateTriangle();
    }
    
    public bool IsRightAngled()
    {
        List<double> sideLengths = new List<double>();
        for (int i = 0; i < Lines.Count; i++)
        {
            sideLengths.Add(Lines[i].Value);
        }
        sideLengths.Sort();
        double c = sideLengths.Max();
        sideLengths.Remove(c);
        double a = sideLengths[0];
        double b = sideLengths[1];
        
        return Math.Abs(Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2))) < 1e-10;
    } 
    
    public override double Area()
    {
        double a = Lines[0].Value;
        double b = Lines[1].Value;
        double c = Lines[2].Value;
        double s = (a + b + c) / 2; 
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }

    private void ValidateTriangle()
    {
        if (!IsValidTriangle())
        {
            throw new FigureNotExistException
                ($"Figure with corresponding sides doesn't exist {Lines[0]} {Lines[1]} {Lines[2]}");
        }
    }
    private bool IsValidTriangle()
    {
        double[] sideLengths = new double[3];
        for (int i = 0; i < Lines.Count; i++)
        {
            sideLengths[i] = Lines[i].Value;
        }
        Array.Sort(sideLengths);
        return (sideLengths[0] + sideLengths[1] > sideLengths[2]);
    }
    
}
