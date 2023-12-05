internal class IsoscelesTriangle : Triangle
{
    // блок конструктора
    public IsoscelesTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
    {
    }

    // метод расчета площади равнобедренного треугольника
    public override double getSquare()
    {
        double side;
        double baseTriangle;
        if (lengthA == lengthB)
        {
            side = lengthA;
            baseTriangle = lengthC;
        }
        else if (lengthB == lengthC) 
        {
            side = lengthB;
            baseTriangle = lengthA;
        } 
        else
        {
            side = lengthC;
            baseTriangle = lengthB;
        }
        double square = 0.5 * baseTriangle * Math.Sqrt(Math.Pow(side,2) - (Math.Pow(baseTriangle,2) / 4));
        return square;
    }
}
