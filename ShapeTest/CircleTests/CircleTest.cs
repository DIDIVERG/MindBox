using FluentAssertions;
using ShapeLib.Shapes;

namespace ShapeTests.CircleTests;

public class CircleTest
{
    private const double Pi = Math.PI;

    [Fact]
    public void Circle_Area_ShouldBeEqualValue()
    {
        //arrange
        double radius = 3;
        Circle circle = new Circle(radius);
        //act
        var value = Pi * Math.Pow(radius, 2);
        var area = circle.Area();
        //assert 
        area.Should().Be(value);
    }
}