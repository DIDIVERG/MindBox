using FluentAssertions;
using ShapeLib;
using ShapeLib.Shapes;

namespace ShapeTest;

public class ShapeCalculatorTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectArea_ForCircle()
    {
        // Arrange
        var calculator = new ShapeCalculator();
        var points = new List<Point>
        {
            new Point(0, 0),
            new Point(0, 3)
        };
        var circle = new Circle(points);

        // Act
        double area = calculator.CalculateArea(circle);
        // Assert
        area.Should().BeApproximately(28.27, 0.01); // Approximately asserts that the area is close to 28.27 with a precision of 0.01
    }

    [Fact]
    public void CalculateArea_ShouldReturnCorrectArea_ForTriangle()
    {
        // Arrange
        var calculator = new ShapeCalculator();
        var lines = new List<Line>
        {
            new Line(3),
            new Line(4),
            new Line(5)
        };
        var triangle = new Triangle(lines);
        // Act
        double area = calculator.CalculateArea(triangle);
        // Assert
        area.Should().Be(6); 
    }
}