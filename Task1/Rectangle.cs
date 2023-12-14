namespace Task1
{
    internal class Rectangle : Triangle
    {
        private double lengthA;
        private double lengthB;

        protected Rectangle() { }
        public Rectangle(double lengthA, double lengthB)
        {
            this.lengthA = lengthA;
            this.lengthB = lengthB;
        }

        public override double GetSquare()
        {
            double square = lengthA * lengthB;
            return square;
        }

        public override double GetPerimeter()
        {
            return (lengthA+lengthB)*2;
        }
    }
}
