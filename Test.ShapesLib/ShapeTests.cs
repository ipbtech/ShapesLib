using ShapesLib.Abstract;
using ShapesLib.Shapes;

namespace Test.ShapesLib
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_ValueSuccess()
        {
            //Arrange
            BaseShape circle = new Circle(3);
            var expect = 28.27;

            //Act
            var result = circle.Area;

            //Assert
            Assert.Equal(expect, result);
        }


        [Fact]
        public void Circle_ValueWrong()
        {
            //Arrange
            BaseShape circle = new Circle(5);
            var expect = 28.27;

            //Act
            var result = circle.Area;

            //Assert
            Assert.NotEqual(expect, result);
        }

        [Fact]
        public void Circle_CreateFailed()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }


        [Fact]
        public void Triangle_ValueSuccess()
        {
            //Arrange
            BaseShape triangle = new Triangle(3, 5, 7);
            var expect = 6.50;

            //Act
            var result = triangle.Area;

            //Assert
            Assert.Equal(expect, result);
        }


        [Fact]
        public void Triangle_ValueWrong()
        {
            //Arrange
            BaseShape triangle = new Triangle(4, 4, 3);
            var expect = 27;

            //Act
            var result = triangle.Area;

            //Assert
            Assert.NotEqual(expect, result);
        }

        [Fact]
        public void Triangle_CreateFailed()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => new Triangle(0, 6, -2));
            Assert.Throws<ArgumentException>(() => new Triangle(-1, -3, 6));
            Assert.Throws<ArgumentException>(() => new Triangle(10, 5, 4));
        }


        [Fact]
        public void Triangle_IsNotReactangle()
        {
            //Arrange
            Triangle triangle = new Triangle(4, 4, 3);

            //Act
            var result = triangle.IsRectangle();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Triangle_IsReactangle()
        {
            //Arrange
            Triangle triangle = new Triangle(4, 5, 3);

            //Act
            var result = triangle.IsRectangle();

            //Assert
            Assert.True(result);
        }



        [Fact]
        public void Shapes_DifferentTypes()
        {
            //Arrange
            var shapes = new List<BaseShape>()
            {
                new Triangle(3, 7, 9),
                new Circle(4),
                new Triangle(6, 7, 8),
                new Circle(1),
            };

            //Act
            var result = shapes.Select(shape => shape.Area).ToList();

            //Assert
            Assert.Equal(4, result.Count);
        }
    }
}