using NUnit.Framework;



    [TestFixture]
    public class ScientificCalculatorTests
    {
        [Test]
        public void Power_ShouldReturnSquaredValue()
        {
            double result = Calculator.ScientificCalculator.Power(3);
            Assert.AreEqual(9, result, 0.0001);
        }

        [Test]
        public void Sqrt_ShouldReturnSquareRoot()
        {
            double result = Calculator.ScientificCalculator.Sqrt(9);
            Assert.AreEqual(3, result, 0.0001);
        }

        [Test]
        public void Log_ShouldReturnNaturalLogarithm()
        {
            double result = Calculator.ScientificCalculator.Log(Math.E);
            Assert.AreEqual(1, result, 0.0001);
        }

        [Test]
        public void MultiSum_ShouldReturnSumOfNumbers()
        {
            double result = Calculator.ScientificCalculator.MultiSum("1 2 3 4,5");
            Assert.AreEqual(10.5, result, 0.1);
        }

        [Test]
        public void Avg_ShouldReturnAverageOfNumbers()
        {
            double result = Calculator.ScientificCalculator.Avg("1 2 3 4");
            Assert.AreEqual(2.5, result, 0.1);
        }

        [Test]
        public void MinMax_ShouldReturnCorrectMinMax()
        {
            double[] result = Calculator.ScientificCalculator.MinMax("3 1 4 1 5 9");
            Assert.AreEqual(1, result[0], 0.0001);
            Assert.AreEqual(9, result[1], 0.0001);
        }
        

        [Test]
        public void MultiSum_ShouldHandleEmptyString()
        {
            double result = Calculator.ScientificCalculator.MultiSum("");
            Assert.AreEqual(0, result, 0.0001);
        }

        [Test]
        public void MinMax_ShouldHandleEmptyString()
        {
            double[] result = Calculator.ScientificCalculator.MinMax("");
            Assert.AreEqual(double.MaxValue, result[0]);
            Assert.AreEqual(double.MinValue, result[1]);
        }
    }