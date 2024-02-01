using System;
namespace NestedForLoops
{
    class NestedFor
    {
        public static void NestedFor2dArray()
        {
            int[,] marks = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            // foreach (int element in marks)
            // {
            //     System.Console.Write(element + " ");
            //     // element = 3;     -> not possible give error for resolve this thing use nested for loop
            // }

            System.Console.WriteLine("odd number");

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    // if ((marks[i, j]) % 2 == 0)
                    //     continue;
                    // else
                    //     System.Console.Write(marks[i, j] + " ");

                    if (i == j)
                    {
                        System.Console.WriteLine(marks[i, j]);
                    }

                }
            }

            for (int i = 0, j = 2; i < marks.GetLength(0); i++, j--)
            {
                System.Console.WriteLine(marks[i, j]);

            }

        }
    }
}