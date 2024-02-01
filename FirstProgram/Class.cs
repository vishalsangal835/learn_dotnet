using System;
using System.Runtime.InteropServices;

namespace ClassesAndObjects
{
    internal class Car
    {
        private string _name;
        private int _hp;

        public Car()
        {
            _name = "Car";
            _hp = 0;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _maxSpeed;
        //prop and then press tab

        public int MaxSpeed { get; set; }   // get accessor and set accessor

        public int MaxSpeed1 { get; } = 10;  // set any value is not possible only get value

        public int MaxSpeed2
        {
            set
            {
                _maxSpeed = value;
            }
        }



        // public Car(string name, params int[] hp) // with the help of params you can make only one parameter is optional and it
        // is compulsory it is last and at least one dimensional array
        public Car(string name, [Optional] int hp)    // by default value of hp=0
        {
            _name = name;
            _hp = hp;
            System.Console.WriteLine(" {0} was created", _name);
        }
        public void Drive()
        {
            System.Console.WriteLine("{0} is driving", _name);
        }
        public void Stop()
        {
            System.Console.WriteLine("{0} stoppped", _name);
        }
        public void Details()
        {
            System.Console.WriteLine("The car " + _name + " has " + _hp + "hp. ");
        }
    }
}