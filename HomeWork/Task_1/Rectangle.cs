public class Rectangle
{
    // блок переменных
    double x;
    double y;

    // блок конструктора
    public Rectangle(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // блок методов
    public double getSquare()
    {
        double square = x * y;
        return square;
    }
}