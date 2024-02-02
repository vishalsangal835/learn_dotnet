using System;
using System.Collections;

namespace ArrayList_01
{
    class ArrayList_1
    {
        public static void ArrayList2()
        {
            ArrayList myArrList = new ArrayList();
            ArrayList myArrList2 = new ArrayList(100);
            myArrList.Add(10);
            myArrList.Add(20);
            myArrList.Add(20);
            myArrList.Add(30);
            myArrList.Add(10.10);
            myArrList.Add(20.20);
            myArrList.Add(30.30);
            myArrList.Add("Hello");
            myArrList.Add("how are");
            myArrList.Add("YOU");

            System.Console.WriteLine(myArrList.Count);



            myArrList.Remove(20);      //  Remove method  remove the first occurence of number only if it is present more than 1 time 
            myArrList.RemoveAt(0);

            double sum = 0;
            foreach (object obj in myArrList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                if (obj is double)
                {
                    sum += (double)obj;
                }
                if (obj is string)
                {
                    System.Console.WriteLine("{0}", obj);
                }

            }
            System.Console.WriteLine(sum);

        }
    }
}