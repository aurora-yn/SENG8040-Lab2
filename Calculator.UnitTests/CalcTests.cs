using NUnit.Framework;
using Calculator;
using System;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void Addition_Input_Same()
        {
            // Arrange
            var calc = new Calc();
            
            bool result = (calc.Addition(1, 3)) == 4;

            // Assert
            Assert.That(result == true);

        }
    }
}