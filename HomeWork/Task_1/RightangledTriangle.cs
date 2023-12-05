internal class RightangledTriangle : Triangle
{
    public RightangledTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
    {
    }

    // метод расчета площади прямоугольный треугольника
    public override double getSquare()
    {
        double cathetus1;
        double cathetus2;
        if (lengthA < lengthB)
        {
            cathetus1 = lengthA;

            if (lengthB < lengthC) 
            {
                cathetus2 = lengthB;
            }
            else
            {
                cathetus2 = lengthC;
            }
        }
        else
        {
            cathetus1 = lengthB;
            if (lengthA < lengthC)
            {
                cathetus2 = lengthA;
            }
            else
            {
                cathetus2 = lengthC;
            }
        }
        double square = 0.5 * cathetus1 * cathetus2;
        return square;
    }
}
