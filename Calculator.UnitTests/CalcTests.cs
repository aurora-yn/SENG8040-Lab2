using System;
using NUnit.Framework;


namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void Addition_Input_True()
        {
            // Arrange
            var calc = new Calc();
            // Act
            bool result = (calc.Addition(1, 3)) == 4;
            // Assert
            Assert.That(result == true);
        }
        [Test]
        public void Addition_InputPoint_True()
        {
            var calc = new Calc();
            bool result = (calc.Addition(1.4, 2)) == 3.4;
            Assert.That(result == true);
        }
        [Test]
        public void Addition_InputNegative_True()
        {
            var calc = new Calc();
            bool result = (calc.Addition(-2, -3.2)) == -5.2;
            Assert.That(result == true);
        }
        [Test]
        public void Subtraction_Input_True()
        {
            var calc = new Calc();
            bool result = (calc.Subtraction(10, 3)) == 7;
            Assert.That(result == true);
        }
        [Test]
        public void Subtraction_InputPoint_True()
        {
            var calc = new Calc();
            bool result = (calc.Subtraction(5.4, 2.2)) == 3.2;
            Assert.That(result == true);
        }
        [Test]
        public void Subtraction_InputNegative_True()
        {
            var calc = new Calc();
            bool result = (calc.Subtraction(-3, -2)) == -1;
            Assert.That(result == true);
        }
        [Test]
        public void Multiplication_Input_True()
        {
            var calc = new Calc();
            bool result = (calc.Multiplication(4, 3)) == 12;
            Assert.That(result == true);
        }
        [Test]
        public void Multiplication_InputPoint_True()
        {
            var calc = new Calc();
            bool result = calc.Multiplication(3, 1.5) == 4.5;
            Assert.That(result == true);
        }
        [Test]
        public void Multiplication_InputNegative_True()
        {
            var calc = new Calc();
            bool result = (calc.Multiplication(-2, -2.1)) == 4.2;
            Assert.That(result == true);
        }
        [Test]
        public void Division_Input_True()
        {
            var calc = new Calc();
            bool result = (calc.Division(6, 3)) == 2;
            Assert.That(result == true);
        }
        [Test]
        public void Division_InputPoint_True()
        {
            var calc = new Calc();
            bool result = calc.Division(3, 1.5) == 2;
            Assert.That(result == true);
        }
        [Test]
        public void Division_InputNegative_True()
        {
            var calc = new Calc();
            bool result = (calc.Division(-2, -1)) == 2;
            Assert.That(result == true);
        }
    }
}