/// <summary>
/// Total namespace
/// </summary>
namespace EPAMTask
{
    /// <summary>
    /// Class with custom exception
    /// </summary>
    public class NumberOfValuesException : Exception
    {
        /// <summary>
        /// Custom exception constructor
        /// </summary>
        /// <param name="message">Text of exception</param>
        public NumberOfValuesException(string message) : base(message) { }
    }
}
