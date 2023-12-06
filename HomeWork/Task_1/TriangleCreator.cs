namespace HomeWork
{
    public class TriangleCreator
    {
        public Triangle CreateTriangle(double lengthA, double lengthB, double lengthC)
        {
            // проверка на равносторнний
            if (lengthA == lengthB && lengthB == lengthC)
            {
                Triangle scaleneTriangle = new ScaleneTriangle(lengthA, lengthB, lengthC);
                return scaleneTriangle;
            }
            // проверка на равнобедренный
            if (lengthA == lengthB || lengthA == lengthC || lengthB == lengthC)
            {
                Triangle isoscelesTriangle = new IsoscelesTriangle(lengthA, lengthB, lengthC); 
                return isoscelesTriangle;

            }
            // проверка на разносторонний
            if (lengthA != lengthB && lengthB != lengthC)
            {
                Triangle diffTriangle = new DiffTriangle(lengthA, lengthB, lengthC);
                return diffTriangle;
            }

            if (lengthA >lengthB && lengthA > lengthC)
            {
                if (lengthA * lengthA == lengthB * lengthB + lengthC * lengthC)
                {
                    Triangle rightangleTriangle = new RightangledTriangle(lengthA, lengthB, lengthC);
                    return rightangleTriangle;
                }
            }

            if (lengthB > lengthA && lengthB > lengthC)
            {
                if (lengthB * lengthB == lengthA * lengthA + lengthC * lengthC)
                {
                    Triangle rightangleTriangle = new RightangledTriangle(lengthA, lengthB, lengthC);
                    return rightangleTriangle;
                }
            }

            if (lengthC > lengthA && lengthC > lengthB)
            {
                if (lengthC * lengthC == lengthB * lengthB + lengthA * lengthA)
                {
                    Triangle rightangleTriangle = new RightangledTriangle(lengthA, lengthB, lengthC);
                    return rightangleTriangle;
                }
            }

            Triangle baseTriangle = new Triangle(lengthA, lengthB, lengthC);
            return baseTriangle;
        }
    }
}
