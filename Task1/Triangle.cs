namespace Task1
{
    internal class Triangle : Figure
    {
        private double lengthA;
        private double lengthB;
        private double lengthC;

        protected Triangle() { }
        public Triangle(double lengthA, double lengthB, double lengthC)
        {
            this.lengthA = lengthA;
            this.lengthB = lengthB;
            this.lengthC = lengthC;
        }

        public override double GetPerimeter()
        {
            return lengthA+lengthB+lengthC;
        }

        public override double GetSquare()
        {
            double semiperimeter;
            semiperimeter = 0.5 * (lengthA + lengthB + lengthC);
            double square = Math.Sqrt(semiperimeter * (semiperimeter - lengthA) * (semiperimeter - lengthB) * (semiperimeter - lengthC));
            return square;
        }
    }
}
