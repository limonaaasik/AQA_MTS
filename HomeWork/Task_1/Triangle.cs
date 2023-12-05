public class Triangle
{
    // блок переменных
    public double lengthA;
    public double lengthB;
    public double lengthC;

    // блок конструктора
    public Triangle(double lengthA, double lengthB, double lengthC)
    {
        this.lengthA = lengthA;
        this.lengthB = lengthB;
        this.lengthC = lengthC;
    }

    // блок методов
    public virtual double getSquare()
    {
        double semiperimeter;
        semiperimeter = 0.5 * (lengthA + lengthB + lengthC);
        double square = Math.Sqrt(semiperimeter * (semiperimeter - lengthA) * (semiperimeter - lengthB) * (semiperimeter - lengthC));
        return square;
    }
}