
using HomeWork.Task_1;

namespace HomeWork
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            FigureCreator creator = new FigureCreator();
            Figure[] figures = new Figure[10];
            figures[0] = creator.CreateTriangle(6, 6, 6);
            figures[1] = creator.CreateTriangle(8, 6, 8);
            figures[2] = creator.CreateTriangle(3, 4, 5);
            figures[3] = creator.CreateTriangle(24, 96, 89);
            figures[4] = creator.CreateRectangle(4.6, 8);
            figures[5] = creator.CreateRectangle(8, 8);
            figures[6] = creator.CreateRectangle(81, 8);
            figures[7] = creator.CreateRectangle(99, 99);
            figures[8] = creator.CreateTriangle(10, 6, 6);
            figures[9] = creator.CreateTriangle(21.1, 21.1, 21.1);

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine($"{figures[i]}, Площадь: {figures[i].getSquare()}");
            }
        }
    }
}
