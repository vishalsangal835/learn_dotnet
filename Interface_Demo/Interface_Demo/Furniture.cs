using System;
namespace InheritanceDemo2
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture()
        {
            Color = "White";
            Material = "wood";
        }
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;

        }
    }
}