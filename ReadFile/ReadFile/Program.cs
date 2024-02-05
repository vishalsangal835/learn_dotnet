﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading Tect from a File
            //exchange the adress of the file with the one you want to use
            string text = System.IO.File.ReadAllText(@"C:\Users\DELL\OneDrive\Desktop\dotnet learn\ReadFile\sample1.txt");

            Console.WriteLine("Textfile contains the following text: {0}", text);

            //Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DELL\OneDrive\Desktop\dotnet learn\ReadFile\sample1.txt");

            Console.WriteLine("Content of the file line by line:");
            foreach (string line in lines)
            {
                //\t is a tab
                Console.WriteLine("\t" + line);
            }

            //To keep the Console open.
            Console.Read();
        }
    }
}
