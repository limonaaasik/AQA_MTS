using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_HW
{
    [TestFixture, Category("Домашнее задание 1")]
    internal class CalcTest
    {
        [OneTimeSetUp] 
        public void SetUp() 
        {
            Console.WriteLine("Какая-то настройка");
        }

        [Test(Description = "Сравнение строк")]
        [Author("Ксения Макушева", "test.email@gmail.com")]
        [Severity(SeverityLevel.Minor)]
        public void AreEqualTest()
        {
            Assert.IsTrue("мама" == "мама");
        }

        [Test]
        [Repeat(3)]
        [Severity(SeverityLevel.Minor)]
        public void RandomValuesTest(
        [Random(-10.0, 100.0, 2)] double randNum)
        {
            Console.WriteLine($"{this}: Рандомные числа {randNum}");
        }

        [Test]
        [Ignore("В следующий релиз")]
        public void TestNextRelease()
        {
            Assert.IsTrue("мама" == "папа");
        }

        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(1, 10, ExpectedResult = 13)]
        [Category("Проверка суммы")]
        [Severity(SeverityLevel.Major)]
        public int CalcSumIntCorrectValues(int a, int b)
        {
            return Calc.Sum(a, b);
        }

        [TestCaseSource(typeof(DivideData), nameof(DivideData.DivideCasesInt))]
        [Order(1)]
        [Category("Деление Int")]
        [Severity(SeverityLevel.Major)]
        public void CalcDivideIntCorrectValues(int x, int y, int result)
        {
            Assert.That(x / y, Is.EqualTo(result));
        }

        [TestCaseSource(typeof(DivideData), nameof(DivideData.DivideCasesDouble))]
        [Order(1)]
        [Category("Деление Double")]
        [Severity(SeverityLevel.Major)]
        public void CalcDivideDoubleCorrectValues(int x, int y, int result)
        {
            Assert.That(x / y, Is.EqualTo(result));
        }

        [Test]
        [Order(0)]
        [Description("INT: Проверка ошибки деления на ноль")]
        [Severity(SeverityLevel.Critical)]
        public void CalcOnZeroDouble()
        {
            if (double.IsInfinity((double)2 / 0))
                Assert.Pass("Деление на нуль произошло");
            else
                Assert.Fail("Ошибка деления на нуль");
        }

        [Test]
        [Order(0)]
        [Description("DOUBLE: Проверка ошибки деления на нольь")]
        [Severity(SeverityLevel.Critical)]
        public void CalcOnZeroInt()
        {
            Assert.Throws<DivideByZeroException>(() => Calc.DivInt(5, 0));  // выдаст true(pass), потому что деление на нуль невозможно в интах
        }

        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            Console.WriteLine("Вернуть все настройки в исходное значение...");
        }
    }
}
