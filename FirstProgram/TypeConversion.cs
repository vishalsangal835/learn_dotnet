using System;

namespace HelloWorld
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            // impicit conversion
            int num = 12390532;
            long bigNum = num;
            float myFloat = 13.37F;
            double myNewDouble = myFloat;
            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;
            // typeConversion 
            string myString1 = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);
            Console.Read();
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            double db = Double.Parse(myString);
            //   int num1 = int.Parse(myString);
            // int num2 = int.Parse(mySecondString);
            // double db = double.Parse(myString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();



            string name = "Vishal";
            int age = 25;


            //string concatenation
            System.Console.WriteLine("my name is " + name + " my age is " + age);

            //string formatting uses index
            System.Console.WriteLine("my name is {0} \n my age is {1}", name, age);

            //string interpolation
            //string interpolation uses $ at the start which will allow us to write our  variable like this {variablename}
            System.Console.WriteLine($"my name is {name} and my age is {age}");

            //verbatim strings
            //verbatim strings start with @and tells the compiler to take the string 
            //literally and ignore any spaces and escape character like \n
            System.Console.WriteLine(@"my name is {0}
             and my age is {1}", name, age);
            System.Console.WriteLine(@"https://learn.microsoft.com/en-us/dotnet/api/system.string?view=netcore-3.1");

            System.Console.WriteLine(name.IndexOf('V'));
            System.Console.WriteLine(name.ToUpper());
            System.Console.WriteLine(name.Substring(2));
            System.Console.WriteLine(name.ToLower());
            string fullName = string.Concat(" ", name, " Sangal", " ");
            Console.WriteLine(fullName);
            System.Console.WriteLine(fullName.Length);
            System.Console.WriteLine((fullName.Trim()).Length);
            System.Console.WriteLine(string.Format("My name is {0}", name));
            System.Console.WriteLine(string.IsNullOrWhiteSpace(name));

            string s1 = "this is a \"string\" with \n  a backslash \\ and a colon ";
            System.Console.WriteLine(s1);



            //assignment -1 


            string s;
            System.Console.WriteLine("please enter your name  and press enter");
            s = Console.ReadLine();
            System.Console.WriteLine(s.ToUpper());
            System.Console.WriteLine(s.ToLower());
            System.Console.WriteLine(s.Trim());
            System.Console.WriteLine(s.Substring(0, 3));
            // first value =  starting index
            //  second value = length of substring   
            System.Console.ReadKey();


            // datatype --------------------------------------------------datatype ---------------------------------------------

            byte myByte = 25; //(0 to 255)
            System.Console.WriteLine(myByte);

            sbyte mySmByte = -15; //(-128 to 127)
            System.Console.WriteLine(mySmByte);

            int a = -20;
            uint b = 20;
            long c = -80;
            ulong d = 80;
            short e = -80;
            ushort f = 80;
            char g = 'j';
            float h = 2.15f;
            double i = 3.165;
            string j = "kkkkkkkkkkkkkkkkkkkkkkkkkkk";
            string k = "15";
            System.Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i},{j}");

            int number = int.Parse(k);
            var number1 = 0;  //int
            number1 = 5;
            var str = "kkkk";  //string
            var isExist = true; //boolean

            // var isNull=null;      -> error -> if u declared any variable with var keyword then always
            // initialize at the time of declaration
            // otherwise your code not run properly and give error.


            // Constants are immutable values which are known 
            // at compile time and do not change for the life of the program. 

            // constants as fields
            const double PI = 3.14159265359;
            const int weeks = 52, months = 12;
            // Create a constant of type string with your birthday as its value
            const string birthday = "31.05.1988";
            const string birthday2 = "05.31.1988";
            const string birthday3 = "2018-05-31";
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.ReadKey();



        }

    }
}
