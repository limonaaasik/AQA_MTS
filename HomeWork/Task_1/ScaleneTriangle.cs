internal class ScaleneTriangle : Triangle
{
    public ScaleneTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
    {
    }

    // метод расчета площади равностороннего треугольника
    public override double getSquare()
    {
        double square = (Math.Pow(lengthA, 2) * Math.Sqrt(3)) / 4;
        return square;
    }
}
