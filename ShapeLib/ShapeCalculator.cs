using ShapeLib.Shapes;

namespace ShapeLib;
// this class for computing area without knowledge of what kind of shape was put in methods
public class ShapeCalculator
{
    public double CalculateArea(Shape shape)
    {
        return shape.Area();
    }
}