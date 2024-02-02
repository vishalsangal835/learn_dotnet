using System;
using System.Collections;
using X;
namespace _01_hash
{

    class HashTable1
    {
        public static void HashTable2()
        {

            Hashtable my_hashtable1 = new Hashtable();
            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "GeeksforGeeks");

            foreach (DictionaryEntry ele in my_hashtable1)
            {
                System.Console.WriteLine("{0} , {1}", ele.Key, ele.Value);

            }

            Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                      {2, 234},
                                      {3, 230.45},
                                      {4, null}};

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine("{0}and {1}", ele2,
                                my_hashtable2[ele2]);
            }


            my_hashtable1.Remove("A1");
            my_hashtable1.Clear();
            my_hashtable1.Contains("A1");
            my_hashtable1.ContainsKey("A1");
            my_hashtable1.ContainsValue("to");



            Student stud1 = new Student(1, "A", 0.1f);
            Student stud2 = new Student(2, "B", 0.2f);
            Student stud3 = new Student(3, "C", 0.3f);
            Student stud4 = new Student(4, "D", 0.4f);

            Hashtable h1 = new Hashtable();
            h1.Add(stud1.Id, stud1);
            h1.Add(stud2.Id, stud2);
            h1.Add(stud3.Id, stud3);
            h1.Add(stud4.Id, stud4);

            Student storedStudent = (Student)h1[1];
            System.Console.WriteLine(storedStudent);
            //  System.Console.WriteLine(storedStudent.Name);
            // System.Console.WriteLine(storedStudent.GPA);

            Student storedStudent1 = (Student)h1[2];
            System.Console.WriteLine(storedStudent1);

            foreach (DictionaryEntry entry in h1)
            {
                Student storedstudent = (Student)entry.Value;
                System.Console.WriteLine(storedstudent.GPA);
            }

        }
    }

}

