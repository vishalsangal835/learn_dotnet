using System;
using System.Globalization;
namespace XYZ
{
    class AX
    {
        // int sum = 0;
        // for (int i = 0; i < number.Length; i++)
        // {
        //     sum += number[i];
        // }
        // return sum;

        public static void Calc()
        {
            int[] number = { 2, 3, 5, 7, 8 };
            int length = number.Length;
            for (int i = length - 1; i >= 0; i--)
                System.Console.Write("{0} ", number[i]);
        }
    }
}