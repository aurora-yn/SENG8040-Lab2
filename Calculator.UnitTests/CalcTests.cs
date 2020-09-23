using NUnit.Framework;
using Calculator;

namespace Calculator.UnitTests
{
    public class CalcTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var calc = new Calc();

            // Act

            // Assert
            Assert.Pass();
        }
    }
}