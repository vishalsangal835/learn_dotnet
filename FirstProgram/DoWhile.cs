using System;

namespace DoWhileLoop
{
    class Program
    {
        public static void DoWhile()
        {

            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks, that was enough! " + wholeText);
            Console.Read();
        }
    }
}
