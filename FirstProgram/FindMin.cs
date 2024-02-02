using System;

namespace _07_Minimum
{
    class MinimumNumber
    {
        public static int MinimumValue1(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (min > number)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
