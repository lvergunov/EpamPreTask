using Xunit;
using EPAMTask;

/// <summary>
/// Namespace of tests
/// </summary>
namespace Tests
{
    /// <summary>
    /// Class with tests
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Method testing whether an exception is fired when passing empty parameters to calculate GCD
        /// </summary>
        [Fact]
        public void TestOfEuclidasAlgorithmException()
        {
            double timeToComplete;
            Assert.Throws<NumberOfValuesException>(() => CounterGCDByEuclidas.FindGCDByEuclidas(out timeToComplete));
        }
        /// <summary>
        /// Test suite for the Euclidean algorithm with different parameters
        /// </summary>
        /// <param name="expectedValue">Expected value of GCD</param>
        /// <param name="testValues">Set of test values</param>
        [Theory]
        [InlineData(3, 111, 432)]
        [InlineData(24, 96, 72)]
        [InlineData(5, 55, 25)]
        [InlineData(1, 25, 11)]
        [InlineData(7, -231, -140)]
        [InlineData(5, 25, 10, 5)]
        [InlineData(11, 55, 44, 121)]
        [InlineData(6, 78, 294, 576, 36)]
        [InlineData(2, 18, 28, 178, 40, 100, 44, 8)]
        [InlineData(10, 10)]
        public void Test_Of_Euclidas_Algorithm(int expectedValue, params int[] testValues)
        {
            double timeToComplete;
            int GCDResult = CounterGCDByEuclidas.FindGCDByEuclidas(out timeToComplete, testValues);
            Assert.Equal(expectedValue, GCDResult);
        }
        /// <summary>
        /// Test suite for the Stein algorithm with different parameters
        /// </summary>
        /// <param name="expectedValue">Expected value of GCD</param>
        /// <param name="firstValue">First test param</param>
        /// <param name="secondValue">Second test param</param>
        [Theory]
        [InlineData(3, 111, 432)]
        [InlineData(24, 96, 72)]
        [InlineData(5, 55, 25)]
        [InlineData(7, -231, -140)]
        public void TestOfSteinAlgorithm(int expectedValue, int firstValue, int secondValue)
        {
            double timeToComplete;
            int GCDResult = CounterGCDByStein.FindGCDByStein(out timeToComplete, firstValue, secondValue);
            Assert.Equal(expectedValue, GCDResult);
        }
    }
}