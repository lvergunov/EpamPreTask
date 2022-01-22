/// <summary>
/// Total namespace
/// </summary>
namespace EPAMTask
{
    /// <summary>
    /// Static class storing data for building a bar graph
    /// </summary>
    public static class StorageOfDataForBarGraph
    {
        /// <summary>
        /// List with the results of calculations using the Stein and Euclidean algorithms
        /// </summary>
        public static List<NewBar> Data = new List<NewBar>(0);
    }
    /// <summary>
    /// Class that creates a new element in the data list for the bar graph
    /// </summary>
    public class NewBar
    {
        /// <summary>
        /// Property that returns the first number
        /// </summary>
        public int FirstValue { get; }
        /// <summary>
        /// Property that returns the second number
        /// </summary>
        public int SecondValue { get; }
        /// <summary>
        /// Property that returns the value of the GCD of the numbers entered above
        /// </summary>
        public int ResultOfGCD { get; }
        /// <summary>
        /// A property that returns the value of the time spent for GCD calculations using the Euclidean algorithm
        /// </summary>
        public double TimeOfEuclidasAlgorithm
        {
            get { return _timeOfEuclidasAlgorithm; }
        }
        /// <summary>
        /// A property that returns the value of the time spent for GCD calculations using the Stein algorithm
        /// </summary>
        public double TimeOfSteinAlgorithm
        {
            get { return _timeOfSteinAlgorithm; }
        }
        /// <summary>
        /// Parameter for storing the time spent for calculations using the Euclid algorithm
        /// </summary>
        private double _timeOfEuclidasAlgorithm;
        /// <summary>
        /// Parameter for storing the time spent for calculations using the Stein algorithm
        /// </summary>
        private double _timeOfSteinAlgorithm;
        /// <summary>
        /// Constructor that creates an instance of the class with the results of GCD calculations and adds it to the total base
        /// </summary>
        /// <param name="firstValue">First integer parameter</param>
        /// <param name="secondValue">Second integer parameter</param>
        public NewBar(int firstValue, int secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            ResultOfGCD = CounterGCDByEuclidas.FindGCDByEuclidas(out _timeOfEuclidasAlgorithm, firstValue, secondValue);
            CounterGCDByStein.FindGCDByStein(out _timeOfSteinAlgorithm, firstValue, secondValue);
            StorageOfDataForBarGraph.Data.Add(this);
        }
    }
}
