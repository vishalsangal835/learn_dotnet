using System;
using System.Collections.Generic;
namespace _01_List
{
    class ArrayList_1
    {
        public static void List1()
        {
            //List<int> list=new List<int>();


            //List<int> list=new List<int>(){1,2,3,4};

            //List<int> list=new List<int>{1,2,3,4};

            var list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int sum = 0;
            foreach (int element in list)
                System.Console.WriteLine(element);

            for (int i = 0; i < list.Count; i++)
                System.Console.WriteLine(list[i]);

            System.Console.WriteLine(sum);
            list.Remove(3);
            System.Console.WriteLine("...........");

            for (int i = 0; i < list.Count; i++)
                System.Console.WriteLine(list[i] + "...." + i);
            int index = 0;
            list.RemoveAt(index);

            list.Clear(); //remove all elements from a list


        }
    }
}