using FluentAssertions;
using ShapeLib;
using ShapeLib.Exceptions;
using ShapeLib.Shapes;

namespace ShapeTest.TriangleTests;

public class TriangleTest
{

   public class TriangleTests
    {
        [Fact]
        public void Triangle_Constructor_ThrowsException_WhenInvalidNumberOfPoints()
        {
            // Arrange
            var points = new List<Point> { new Point(0, 0), new Point(1, 1) };
            // Act & Assert
            Assert.Throws<PointsQuantityException>(() => new Triangle(points));
        }

        [Fact]
        public void Triangle_Constructor_CreatesLines_WhenValidNumberOfPoints()
        {
            // Arrange
            var points = new List<Point> { new Point(0, 0), new Point(0, 1), new Point(1, 0) };
            // Act
            var triangle = new Triangle(points);
            // Assert
            triangle.Lines.Should().HaveCount(3);
        }

        [Fact]
        public void Triangle_Constructor_ThrowsException_WhenInvalidNumberOfLines()
        {
            // Arrange
            var lines = new List<Line> { new Line(new Point(0, 0), new Point(1, 1)) };

            // Act & Assert
            Assert.Throws<LinesQuantityException>(() => new Triangle(lines));
        }

        [Fact]
        public void Triangle_Constructor_CreatesLines_WhenValidNumberOfLines()
        {
            // Arrange
            var lines = new List<Line>
            {
                new Line(new Point(0, 0), new Point(0, 1)),
                new Line(new Point(0, 1), new Point(1, 0)),
                new Line(new Point(1, 0), new Point(0, 0))
            };
            // Act
            var triangle = new Triangle(lines);
            // Assert
            triangle.Lines.Should().HaveCount(3);
        }

        [Fact]
        public void Triangle_Area_ReturnsCorrectArea()
        {
            // Arrange
            var lines = new List<Line>
            {
                new Line(new Point(0, 0), new Point(0, 3)),
                new Line(new Point(0, 3), new Point(4, 0)),
                new Line(new Point(4, 0), new Point(0, 0))
            };
            var triangle = new Triangle(lines);
            // Act
            var area = triangle.Area();
            // Assert
            area.Should().Be(6);
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsTrue_WhenTriangleIsRightAngled()
        {
            // Arrange
            var lines = new List<Line>
            {
                new Line(3),
                new Line(4),
                new Line(5)
            };
            var triangle = new Triangle(lines);
            // Act
            var isRightAngled = triangle.IsRightAngled();
            // Assert
            isRightAngled.Should().BeTrue();
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsFalse_WhenTriangleIsNotRightAngled()
        {
            // Arrange
            var lines = new List<Line>
            {
                new Line(3),
                new Line(4),
                new Line(6)
            };
            var triangle = new Triangle(lines);
            // Act
            var isRightAngled = triangle.IsRightAngled();
            // Assert
             isRightAngled.Should().BeFalse();
        }
    }
}