using FluentAssertions;
using ShapeLib;
using ShapeLib.Exceptions;
using ShapeLib.Shapes;

namespace ShapeTest.CircleTests;

public class CircleTests
{
    [Fact]
    public void Circle_Area_ReturnsCorrectArea()
    {
        // Arrange
        var points = new List<Point>
        {
            new Point(0, 0),
            new Point(0, 3)
        };
        var circle = new Circle(points);
        double expectedArea = 9 * Math.PI; // Expected area for a circle with radius 3
        // Act
        double area = circle.Area();
        // Assert
        area.Should().BeApproximately(expectedArea, 0.001);
    }

    [Fact]
    public void Circle_Constructor_ThrowsException_WhenInvalidPointsQuantity()
    {
        // Arrange
        var points = new List<Point>
        {
            new Point(0, 0),
            new Point(0, 3),
            new Point(3, 0)
        };
        // Act
        Action act = () => new Circle(points);
        // Assert
        act.Should().Throw<PointsQuantityException>();
    }

    [Fact]
    public void Circle_Constructor_ThrowsException_WhenInvalidLinesQuantity()
    {
        // Arrange
        var lines = new List<Line>
        {
            new Line(new Point(0, 0), new Point(0, 3)),
            new Line(new Point(3, 0), new Point(0, 0))
        };
        // Act
        Action act = () => new Circle(lines);
        // Assert
        act.Should().Throw<LinesQuantityException>();
    }
}