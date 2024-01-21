namespace Task_1
{
    internal class DelegateClass
    {
            // Тип делегата
            public delegate int NoParameters();

            public int RandomNumbers()
            {
                Random rnd = new Random();
                return rnd.Next(0, 10);
            }
    }
}
