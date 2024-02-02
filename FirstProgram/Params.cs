using System;

namespace Params
{
    class Params1
    {
        public static double Params(params int[] grades)
        {
            //params is the last parameter of function . (it takes zero or more no. of parameters) of same type if you don't write object 

            int count = 0;
            int number = 0;
            foreach (int num in grades)
            {
                number += num;
                count++;
            }
            if (count != 0)
                return (double)number / (double)count;
            else
                return 0;


        }
    }
}