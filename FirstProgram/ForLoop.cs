using System;
namespace ForLoop
{
    class Program
    {
        public static void ForLoop()
        {
            for (int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            Console.Read();

        }
    }
}