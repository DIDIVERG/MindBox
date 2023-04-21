using FluentAssertions;
using ShapeLib.Shapes;

namespace ShapeTests.TriangleTests;

public class TriangleTest
{

    [Fact]
    public void Triangle_Area_ShoueldBeEqualValue()
    {
        //arrange
        double value = 6;
        double area;
        Triangle triangle = new Triangle(3, 4, 5);
        //act
        area = triangle.Area();
        //assert 
        area.Should().Be(value);
    }
    [Fact]
    public void Triangle_IsRightAngled_ShouldBeTrue()
    {
        //arrange
        var result = false;
        Triangle triangle = new Triangle(3, 4, 5);
        //act
        result = triangle.IsRightAngled();
        //assert 
        result.Should().Be(true);
    }
    [Fact]
    public void Triangle_IsRightAngled_ShouldBeFalse()
    {
        //arrange
        var result = false; 
        Triangle triangle = new Triangle(3, 4, 6);
        //act
        result = triangle.IsRightAngled();
        //assert 
        result.Should().Be(false);
    }

    
}