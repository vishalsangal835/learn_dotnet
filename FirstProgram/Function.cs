using System;

namespace HelloWorld1
{
    class Program
    {

        public static void Operation()
        {
            Console.WriteLine(Add(25, 13));
            Console.WriteLine(Multiply(25, 13));
            Console.WriteLine(Devide(25, 13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}