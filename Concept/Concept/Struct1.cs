
using System;
namespace StructsC
{
    public struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's name is :{0}", name);
            Console.WriteLine("Game 1' was developed by :{0}", developer);
            Console.WriteLine("Game 1's rating is :{0}", rating);
            Console.WriteLine("Game 1 was released in :{0}", releaseDate);
        }
    }
}


