using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class FindMaximumFloat
    {
        public static void GetMax(float firstNumber, float secondNumber, float thirdNumber)
        {
            //// used compareto method
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(firstNumber + ", Is the max value.");
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(secondNumber + ", Is the max value.");
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                Console.WriteLine(thirdNumber + ", Is the max value.");
        }
    }
}
