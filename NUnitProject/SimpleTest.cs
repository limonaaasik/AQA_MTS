namespace NUnitProject
{
    public class SimpleTest
    {
        //[SetUp]
        //public void Setup1()
        //{
        //    Console.WriteLine($"{this}: SetUp1... {++i}");
        //}

        [Test]
        public void Test()
        {
            Console.WriteLine($"{this}: Test...");  // � ������� this ������ ��� �� ���������
            Assert.Pass();
        }
    }
}
