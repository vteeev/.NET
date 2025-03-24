using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalcFunctionsTests
    {
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            double result = CalcFunctions.add(3, 2);
            Assert.AreEqual(5, result, 0.001);  // 3 + 2 = 5

            result = CalcFunctions.add(-3, -2);
            Assert.AreEqual(-5, result, 0.001);  // -3 + (-2) = -5

            result = CalcFunctions.add(-3, 2);
            Assert.AreEqual(-1, result, 0.001);  // -3 + 2 = -1
        }
        
        [Test]
        public void Substract_ShouldReturnCorrectDifference()
        {
            double result = CalcFunctions.Substract(5, 2);
            Assert.AreEqual(3, result, 0.001);  // 5 - 2 = 3

            result = CalcFunctions.Substract(-5, -2);
            Assert.AreEqual(-3, result, 0.001);  // -5 - (-2) = -3

            result = CalcFunctions.Substract(3, 5);
            Assert.AreEqual(-2, result, 0.001);  // 3 - 5 = -2
        }
        
        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            double result = CalcFunctions.Multiply(3, 2);
            Assert.AreEqual(6, result, 0.001);  // 3 * 2 = 6

            result = CalcFunctions.Multiply(-3, -2);
            Assert.AreEqual(6, result, 0.001);  // -3 * -2 = 6

            result = CalcFunctions.Multiply(3, -2);
            Assert.AreEqual(-6, result, 0.001);  // 3 * -2 = -6
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            double result = CalcFunctions.Divide(6, 2);
            Assert.AreEqual(3, result, 0.001);  // 6 / 2 = 3

            result = CalcFunctions.Divide(-6, -2);
            Assert.AreEqual(3, result, 0.001);  // -6 / -2 = 3

            result = CalcFunctions.Divide(6, -2);
            Assert.AreEqual(-3, result, 0.001);  // 6 / -2 = -3
        }
        
    }
}
