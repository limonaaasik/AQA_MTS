using HomeWork.Task_1;

public class Rectangle : Figure
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
    public override double getSquare()
    {
        double square = x * y;
        return square;
    }
}