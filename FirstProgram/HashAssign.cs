using System;
using X;
using System.Collections;

namespace HashAssign
{
    class HashAssign1
    {
        public static void HashAssign2()
        {

            // Student[] students = new Student[]{
            //     new Student(1, "A", 0.1f),
            //     new Student(2, "B", 0.2f),
            //     new Student(3, "C", 0.3f)
            // };
            Student[] students = new Student[4];
            students[0] = new Student(1, "A", 0.1f);
            students[1] = new Student(2, "B", 0.2f);
            students[2] = new Student(3, "C", 0.3f);


            Hashtable h1 = new Hashtable();
            h1.Add(students[0].Id, students[0]);
            h1.Add(students[1].Id, students[1]);
            h1.Add(students[2].Id, students[2]);

            int insertedKey = 1;
            if (h1.ContainsKey(insertedKey))
            {
                System.Console.WriteLine("Already contains");

            }


        }
    }
}