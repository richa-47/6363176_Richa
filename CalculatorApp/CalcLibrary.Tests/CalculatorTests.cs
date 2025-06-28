using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, 4, 3)]
        [TestCase(0, 0, 0)]
        public void Addition_Test(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
