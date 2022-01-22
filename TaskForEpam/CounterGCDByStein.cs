using System.Diagnostics;

/// <summary>
/// Total namespace
/// </summary>
namespace EPAMTask
{
    /// <summary>
    /// Class containing a method for calculating GCD by the Stein's method
    /// </summary>
    public static class CounterGCDByStein
    {
        /// <summary>
        /// Method for calculating GCD by the Stein method
        /// </summary>
        /// <param name="timeToComplete">Output parameter returning the value of the time spent on the calculation</param>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>GCD value for the entire set of numbers</returns>
        public static int FindGCDByStein(out double timeToComplete, int firstValue, int secondValue)
        {
            Stopwatch stopwatch = new Stopwatch();
            firstValue = Math.Abs(firstValue); secondValue = Math.Abs(secondValue);
            int k = 1;
            stopwatch.Start();
            while (firstValue != 0 && secondValue != 0)
            {
                if (firstValue % 2 == 0 && secondValue % 2 == 0)
                {
                    while (firstValue % 2 != 0 || secondValue % 2 != 0)
                    {
                        firstValue /= 2; secondValue /= 2; k *= 2;
                    }
                }
                else if (firstValue % 2 == 0 || secondValue % 2 != 0)
                {
                    while (firstValue % 2 == 0) firstValue /= 2;
                }
                else if (firstValue % 2 != 0 || secondValue % 2 == 0)
                {
                    while (secondValue % 2 == 0) secondValue /= 2;
                }
                if (firstValue >= secondValue) firstValue -= secondValue;
                else secondValue -= firstValue;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            timeToComplete = Math.Round(ts.TotalMilliseconds, 4);
            return secondValue * k;
        }
    }
}
