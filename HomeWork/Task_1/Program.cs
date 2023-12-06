
namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(7, 7, 12.474);
            isoscelesTriangle.getSquare();
            Console.WriteLine(isoscelesTriangle.getSquare());

            TriangleCreator triangleCreator = new TriangleCreator();
            Triangle triangle = triangleCreator.CreateTriangle(6,6,6);

            Triangle[] triangles = new Triangle[6];
        }
    }
}
