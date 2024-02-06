// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

using System;
using System.Text.RegularExpressions;
namespace StructsC
{

    class MyClass
    {
        // Constructor
        public MyClass()
        {
            Console.WriteLine("Object created.");
        }

        // Finalizer (destructor)
        ~MyClass()
        {
            Console.WriteLine("Object finalized.");
            // Perform cleanup operations here
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Game game1;

            // game1.name = "Pokemon Go";
            // game1.developer = "Niantic";
            // game1.rating = 3.5;
            // game1.releaseDate = "01.07.2016";

            // game1.Display();

            // Enum.Enum1();


            // System.Console.WriteLine(Math.Abs(-25));
            // System.Console.WriteLine(Math.Ceiling(15.2));
            // System.Console.WriteLine(Math.Floor(15.3));
            // System.Console.WriteLine(Math.Max(5, 7));
            // System.Console.WriteLine(int.MaxValue);
            // System.Console.WriteLine(int.MinValue);

            // Random dice = new Random();
            // int number;
            // for (int i = 0; i < 10; i++)
            // {
            //     number = dice.Next(1, 7);
            //     System.Console.WriteLine(number);
            // }

            // Random rand = new Random();

            // // Create a byte array
            // byte[] byteArray = new byte[10]; // Creating a byte array of size 10

            // // Fill the byte array with random numbers
            // rand.NextBytes(byteArray);

            // // Print the generated random byte array
            // Console.WriteLine("Random Byte Array:");
            // foreach (byte b in byteArray)
            // {
            //     Console.WriteLine(b);
            // }



            // string pattern = @"(\d{3})-(\d{3})-(\d{4})";
            // string text = "Phone numbers: 123-456-7890, 555-555-5555";

            // Regex regex = new Regex(pattern);
            // MatchCollection matches = regex.Matches(text);

            // foreach (Match match in matches)
            // {
            //     Console.WriteLine("Full match: " + match.Value);
            //     Console.WriteLine("Area code: " + match.Groups[1].Value);
            //     Console.WriteLine("Prefix: " + match.Groups[2].Value);
            //     Console.WriteLine("Line number: " + match.Groups[3].Value);
            // }

            Regex regex = new Regex(@"\d");



            // Test string
            string text = "Hi there 123";

            // Find hits
            MatchCollection hits = regex.Matches(text);
            System.Console.WriteLine(regex.IsMatch(text));

            // Anzahl der Treffer
            Console.WriteLine("{0} hits found:\n   {1}",
                              hits.Count,
                              text);

            // amount of hits
            foreach (Match aHit in hits)
            {
                GroupCollection groups = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}",
                                  groups[0].Value,
                                  groups[0].Index
                                 );
            }

            //nullable


            int? num1 = null;
            int? num2 = 15;
            int num3;
            bool? isMale = new bool?();
            if (num1 == null)
            {
                num3 = 9;
            }
            else
            {
                num3 = (int)num2;
            }
            System.Console.WriteLine(num3);

            Nullable<int> nullableInttt = null;

            // the null coalesing operator (??)
            int? nullableInt = null;
            int result = nullableInt ?? -1;

            int? nullableIntt = null;
            int? anotherNullableInt = 10;
            int result1 = nullableInt ?? anotherNullableInt ?? -1; // If both nullableInt and anotherNullableInt are null, result will be -1


            // Create an object
            MyClass obj = new MyClass();

            // Let's assume the object is no longer needed
            // The finalizer will be invoked when the object is garbage collected
            obj = null;

            // Force garbage collection to reclaim the memory
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Program ends.");

            DateTime dt1 = new DateTime(2023, 5, 15); // May 15, 2023, 12:00:00 AM
            DateTime dt2 = new DateTime(2023, 5, 15, 15, 30, 0); // May 15, 2023, 3:30:00 PM
            DateTime dt3 = DateTime.Now;
            System.Console.WriteLine(dt1.Year);
            System.Console.WriteLine(dt1.Hour);
            System.Console.WriteLine(dt1.Minute);
            System.Console.WriteLine(dt1.Second);
            System.Console.WriteLine(dt1.Millisecond);
            System.Console.WriteLine(dt1.Date);
            System.Console.WriteLine(dt1.Month);
            System.Console.WriteLine(dt1.Day);
            System.Console.WriteLine(dt1.DayOfWeek);
            System.Console.WriteLine(dt1.DayOfYear);

            string formattedDate = dt1.ToString("yyyy-MM-dd"); // "2023-05-15"
            DateTime parsedDate = DateTime.Parse("2023-05-15"); // May 15, 2023, 12:00:00 AM
            DateTime futureDate = dt1.AddDays(7); // Adds 7 days to dt1
            System.Console.WriteLine(futureDate);
            TimeSpan difference = dt2 - dt1; // Calculates the time difference between dt2 and dt1
            System.Console.WriteLine(difference);
            System.Console.WriteLine(DateTime.MaxValue);
            System.Console.WriteLine(DateTime.MinValue);
            System.Console.WriteLine(DateTime.Today);
            System.Console.WriteLine(DateTime.Now);
            DateTime tomorrow = GetTomorrow();
            System.Console.WriteLine(tomorrow.Day);
            System.Console.WriteLine(tomorrow.DayOfWeek);
            System.Console.WriteLine(DateTime.Today.DayOfWeek);
            System.Console.WriteLine(DateTime.DaysInMonth(2024, 2));

            DateTime now = DateTime.Now;
            DateTime dateTime;
            System.Console.WriteLine("Write a date in this format : yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                System.Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                System.Console.WriteLine("Days passed {0}", daysPassed.Days);
            }
            else
            {
                System.Console.WriteLine("Wrong input");
            }

            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {

            return DateTime.Today.AddDays(1);
        }
    }
}
