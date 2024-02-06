using System;
namespace InheritanceDemo2
{

    class Program
    {
        public static void Main(string[] args)
        {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "wood");

            Car damagedCar = new Car(80f, "Blue");
            damagedCar.DestroyablesNearBy.Add(officeChair);
            damagedCar.DestroyablesNearBy.Add(gamingChair);
            damagedCar.Destroy();

            var collection = new StudentCollection();
            collection.Add(new Student { Name = "John Doe", Age = 20 });
            collection.Add(new Student { Name = "Jane Smith", Age = 22 });
            collection.Add(new Student { Name = "Alex Johnson", Age = 21 });

            foreach (var student in collection)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            MyCollection myCollection = new MyCollection();

            foreach (var item in myCollection.GetCollection())
            {
                Console.WriteLine(item);
            }


        }
    }
}
