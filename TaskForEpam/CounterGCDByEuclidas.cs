using System.Diagnostics;

/// <summary>
/// Total namespace
/// </summary>
namespace EPAMTask
{
    /// <summary>
    /// Class containing a method for calculating GCD by the Euclidean method
    /// </summary>
    public static class CounterGCDByEuclidas
    {
        /// <summary>
        /// Method for calculating the GCD of several numbers using the Euclidean method
        /// </summary>
        /// <param name="timeToComplete">Output parameter returning the value of the time spent on the calculation</param>
        /// <param name="values">Set of parameters for calculating GCD</param>
        /// <returns>GCD value for the entire set of numbers</returns>
        /// <exception cref="NumberOfValuesException">Throws exception if set of params is empty</exception>
        public static int FindGCDByEuclidas(out double timeToComplete, params int[] values)
        {
            if (values.Length != 0)
            {
                timeToComplete = 0;
                int tempGCD = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    double timeOfPart;
                    tempGCD = FindGCDByEuclidas(out timeOfPart, tempGCD, values[i]);
                    timeToComplete += timeOfPart;
                }
                return tempGCD;
            }
            else throw new NumberOfValuesException("The number of parameters cannot be zero");
        }
        /// <summary>
        /// Method for calculating the GCD of two numbers using the Euclidean method
        /// </summary>
        /// <param name="timeToComplete">Output parameter returning the value of the time spent on the calculation</param>
        /// <param name="firstNum">First param</param>
        /// <param name="secondNum">Second param</param>
        /// <returns>GCD value of these two numbers</returns>
        public static int FindGCDByEuclidas(out double timeToComplete, int firstNum, int secondNum)
        {
            firstNum = Math.Abs(firstNum); secondNum = Math.Abs(secondNum);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (firstNum != 0 && secondNum != 0)
            {
                if (firstNum > secondNum) firstNum = firstNum % secondNum;
                else secondNum = secondNum % firstNum;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            timeToComplete = Math.Round(ts.TotalMilliseconds, 4);
            return firstNum + secondNum;
        }
    }
}