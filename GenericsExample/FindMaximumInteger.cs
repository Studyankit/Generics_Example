using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class FindMaximumString
    {
        public static void GetMax<T>(T firstValue, T secondValue, T thirdValue) where T : System.IComparable<T>
        {
            //// used compareto method
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                Console.WriteLine(firstValue + ", Is the max value.");
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                Console.WriteLine(secondValue + ", Is the max value.");
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                Console.WriteLine(thirdValue + ", Is the max value.");
        }
    }
}
