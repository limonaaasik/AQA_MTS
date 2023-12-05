
namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(7, 7, 12.474);
            isoscelesTriangle.getSquare();
            Console.WriteLine(isoscelesTriangle.getSquare());
        }
    }
}
