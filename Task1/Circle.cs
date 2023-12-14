namespace Task1
{
    internal class Circle : Rectangle
    {
        private double radius;
        private const double PI = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetPerimeter()
        {
            double perimeter = 2 * radius * PI;
            return perimeter;
        }

        public override double GetSquare()
        {
            double square = PI * Math.Pow(radius, 2);
            return square;
        }
    }
}
