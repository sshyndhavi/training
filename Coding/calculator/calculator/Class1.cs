using System;

/// <summary>
/// This class represents a simple calculator.
/// </summary>
namespace calculator
{
    public class Calculator
    {
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Subtracts one integer from another and returns the result.
        /// </summary>
        /// <param name="a">The integer to be subtracted from.</param>
        /// <param name="b">The integer to subtract.</param>
        /// <returns>The result of subtracting b from a.</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}

