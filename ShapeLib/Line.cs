using ShapeLib.Exceptions;

namespace ShapeLib;

public sealed class Line
{
    public double Value;
    private Point Point1 { get; set; }
    private Point Point2 { get; set; }

    public Line(Point point1, Point point2)
    {
        Point1 = point1;
        Point2 = point2;
        Value = GetValue();
    }

    public Line(double value)
    {
        Value = value;
    }
    
    private double GetValue()
    {
        double deltaX = Point2.X - Point1.X;
        double deltaY = Point2.Y - Point1.Y;
        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return distance;
    }
}