using System;
using System.Collections.Generic;

namespace _Dictionary
{
    internal class DictionaryEntry1
    {
        public static void DictionaryEntry2()
        {

            Employee[] emp ={
                new Employee("CEO","A",12,20),
                new Employee("Manager","B",13,21),
                new Employee("HR","C",14,21)
               };

            Dictionary<string, Employee> myDictionary = new Dictionary<string, Employee>();

            Dictionary<string, int> myDictionary1 = new Dictionary<string, int>(){
                    {"CEO",1},
                    {"HR",2},
                    {"Secretary",3}
                };



            foreach (Employee employee in emp)
            {
                myDictionary.Add(employee.Role, employee);
            }

            string key = "CTO";

            // 1 method

            if (myDictionary.ContainsKey(key))
            {
                Employee employeeData = myDictionary[key];
                System.Console.WriteLine("Salary is {0}", employeeData.Salary());
                System.Console.WriteLine("Name is {0}", employeeData.Name);
                System.Console.WriteLine("Age is {0}", employeeData.Age);
            }
            else
            {
                System.Console.WriteLine("This key is not exist");
            }


            // 2 method   ->  TryGetValue

            Employee employeeData1 = null;
            if (myDictionary.TryGetValue("CEO", out employeeData1))
            {
                System.Console.WriteLine("Salary is {0}", employeeData1.Salary());
                System.Console.WriteLine("Name is {0}", employeeData1.Name);
                System.Console.WriteLine("Age is {0}", employeeData1.Age);

            }
            else
            {
                System.Console.WriteLine("This key is not exist");
            }

            // 3 method  -> using KeyValuePair<TKey ,TValue>

            for (int i = 0; i < myDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = myDictionary.ElementAt(i);
                System.Console.WriteLine(keyValuePair.Key);
                System.Console.WriteLine(keyValuePair.Value);





            }

            foreach (KeyValuePair<string, Employee> ele in myDictionary)
            {
                System.Console.WriteLine(ele.Key, ele.Value);
            }

            string KeyToUpdate = "CEO";
            if (myDictionary.ContainsKey(KeyToUpdate))
            {
                myDictionary[KeyToUpdate] = new Employee("CEO", "Z", 6, 125);
            }
            else
            {
                System.Console.WriteLine("Key not present in mydictionary");
            }

            System.Console.WriteLine(myDictionary.Remove("CEO"));






        }
    }

    class Employee
    {

        public Employee(string Role, string Name, int Age, float Rate)
        {

            this.Role = Role;
            this.Age = Age;
            this.Rate = Rate;
            this.Name = Name;


        }
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public float Rate { get; set; }

        public float Salary()
        {
            return Rate * 8 * 5 * 12;

        }
    }
}