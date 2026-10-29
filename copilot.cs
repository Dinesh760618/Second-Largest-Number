using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    internal class copilot
    {
        public long FindSecondLargest()
        {
            int[] numbers = { 12, 7, 25, 4, 18, 9, 30, 6, 15, 11 };

            long largest = long.MinValue;
            long secondLargest = long.MinValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                long value = index % 2 == 1
                    ? (long)numbers[index] * numbers[index]
                    : numbers[index];

                if (value > largest)
                {
                    secondLargest = largest;
                    largest = value;
                }
                else if (value > secondLargest && value != largest)
                {
                    secondLargest = value;
                }
            }

            if (secondLargest == long.MinValue)
            {
                throw new InvalidOperationException("The array must contain at least two distinct values.");
            }

            return secondLargest;
        }
    }
}
