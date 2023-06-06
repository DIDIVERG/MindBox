using ShapeLib.Exceptions;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes;

public class Circle : Shape
{
    // This class uses radius as line
    public Circle(List<Point> points) : base(points)
    {
        if (points.Count != 2)
        {
            throw new PointsQuantityException($"Points quantity must be 2 but this is {points.Count}");
        }
        CreateLines();
    }

    public Circle(List<Line> lines) : base(lines)
    {
        if (lines.Count != 1)
        {
            throw new LinesQuantityException($"Lines quantity must be 1 but this is {lines.Count}");
        }
    }

    public override double Area()
    {
        double radius = Lines[0].Value;
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
}
