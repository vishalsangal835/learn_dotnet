using System;
using System.Runtime.InteropServices;
namespace StructsC
{
    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    enum Month { January = 1, Febuary, March, April, May, June, July = 12, August, September, October, November, December }
    class Enum
    {

        public static void Enum1()
        {

            Day day1 = Day.Thursday;
            Day day2 = Day.Thursday;
            System.Console.WriteLine(day1);
            System.Console.WriteLine(day2);
            Console.WriteLine(day1 == day2);

          

        }
    }
}