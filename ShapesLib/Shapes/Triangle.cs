using ShapesLib.Abstract;

namespace ShapesLib.Shapes
{
    public class Triangle : BaseShape
    {
        
        public int Side1 { get; }
        public int Side2 { get; }
        public int Side3 { get; }

        public override double Area
        {
            get
            {
                double perimeter = (Side1 + Side2 + Side3) / 2.0;
                return Math.Round(Math.Sqrt(perimeter * (perimeter - Side1) * (perimeter - Side2) * (perimeter - Side3)), 2);
            }
        }

        public Triangle(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Sides of triangle must be positive values");

            if (side1 >= (side2 + side3) || side2 >= (side1 + side3) || side3 >= (side1 + side2))
                throw new ArgumentException("One of triangle sides is greater than the sum of two other siders");

            Side1 = side1; 
            Side2 = side2;
            Side3 = side3;
        }


        public bool IsRectangle()
        {
            return Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2)) ||
                    Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2)) ||
                    Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
        }
    }
}
