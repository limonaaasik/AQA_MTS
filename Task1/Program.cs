using Task1;

Figure[] figures = new Figure[5];
figures[0] = new Rectangle(5.5, 6);
figures[1] = new Circle(6);
figures[2] = new Triangle(3.2, 6, 7.25);
figures[3] = new Circle(8.63);
figures[4] = new Rectangle(12.5, 9);

double sumSquare = 0;
double sumPerimeter = 0;
foreach (Figure figure in figures)
{
    sumSquare = sumSquare + figure.GetSquare();
    sumPerimeter += figure.GetPerimeter();
    Console.WriteLine($"Площадь: {figure.GetSquare()}, Периметр: {figure.GetPerimeter()}");
}
Console.WriteLine($"Сумма Площади: {sumSquare}, Сумма Периметра: {sumPerimeter}");

//// ДЛЯ СЕБЯЯ
//double sum = 0;
//sum += figures[0].GetSquare();
//sum = sum + figures[1].GetSquare();
//sum = sum + figures[2].GetSquare();
//sum = sum + figures[3].GetSquare();
//sum = sum + figures[4].GetSquare();