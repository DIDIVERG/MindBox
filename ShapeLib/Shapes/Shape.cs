using ShapeLib.Exceptions;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes;

public abstract class Shape : IShape
{
    private readonly List<Point> _points;
    public List<Line> Lines;
    protected Shape(List<Point> points) : this(points, new List<Line>() )
     {
         _points = points;
     }

     protected Shape(List<Line> lines) : this(new List<Point>(), lines)
     {
         Lines = lines;
     }

     private Shape(List<Point> points, List<Line> lines)
     {
         _points = points;
         Lines = lines;
         if (_points.Count >= 2)
         {
             CreateLines();
         }
     }

     protected void CreateLines()
     {
         Lines = new List<Line>();
         for (int i = 0; i < _points.Count; i++)
         {
             for (int j = i + 1; j < _points.Count; j++)
             {
                 Line line = new Line(_points[i], _points[j]);
                 if (!Lines.Contains(line))
                 {
                     Lines.Add(line);
                 }
             }
         }
     }
     public abstract double Area();

}