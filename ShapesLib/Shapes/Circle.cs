using ShapesLib.Abstract;

namespace ShapesLib.Shapes
{
    public class Circle : BaseShape
    {
        public double Radius { get; }
        public override double Area 
        { 
            get => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius must be positive value");

            Radius = radius;
        }
    }
}
