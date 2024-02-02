using System;
using System.Collections.Generic;
// sorted in ascending order according to key 
namespace SortedDictionary1
{
    class Random
    {

        // Main Method
        static public void SortedDictionary()
        {

            // Creating sorted dictionary
            // Using SortedDictionary class
            SortedDictionary<int, string> My_sdict =
                new SortedDictionary<int, string>();

            // Adding key/value pair in Sorted 
            // Dictionary Using Add() method
            My_sdict.Add(004, "Ask.com");
            My_sdict.Add(003, "Yahoo");
            My_sdict.Add(001, "Google");
            My_sdict.Add(005, "AOL.com");
            My_sdict.Add(002, "Bing");
            Console.WriteLine("Top Search Engines:");

            // Accessing the key/value pair of the 
            // SortedDictionary Using foreach loop
            foreach (KeyValuePair<int, string> pair in My_sdict)
            {
                Console.WriteLine("Rank: {0} and Name: {1}",
                                      pair.Key, pair.Value);
            }

            // Creating another sorted dictionary
            // using SortedDictionary<TKey, TValue> class
            // adding key/value pairs
            // Using collection initializer
            SortedDictionary<int, string> My_sdict1 =
                  new SortedDictionary<int, string>() {
                                     {1, "Python"},
                                      {5, "Swift"},
                                 {2, "JavaScript"},
                                        {4, "Go" },
                                      {3, "Rust"}};


            Console.WriteLine("Top Programming Language in 2019: ");

            // Accessing the key/value pair of the 
            // SortedDictionary Using foreach loop
            foreach (KeyValuePair<int, string> pair in My_sdict1)
            {
                Console.WriteLine("Rank:{0} and Name: {1}",
                                     pair.Key, pair.Value);
            }


            SortedDictionary<int, string> My_sdict2 =
                 new SortedDictionary<int, string>();

            // Adding key/value pair in 
            // SortedDictionary Using 
            // the Add() method
            My_sdict2.Add(001, "Google");
            My_sdict2.Add(002, "Bing");
            My_sdict2.Add(003, "Yahoo");
            My_sdict2.Add(004, "Ask.com");
            My_sdict2.Add(005, "AOL.com");

            // Initial number of key/value pairs
            Console.WriteLine("Key/Value pair: {0}",
                                    My_sdict2.Count);

            // After using Remove(TKey) method
            My_sdict.Remove(002);
            Console.WriteLine("Key/Value pair: {0}",
                                    My_sdict2.Count);

            // After using Clear() method
            My_sdict.Clear();
            Console.WriteLine("Key/Value pair: {0}",
                                    My_sdict2.Count);
        }
    }
}
