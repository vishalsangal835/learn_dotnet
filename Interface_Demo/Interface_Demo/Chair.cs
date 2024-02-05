using System;
namespace InheritanceDemo2
{
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }
        public void Destroy()
        {
            System.Console.WriteLine($"The {Color} Chair was destroyed");
            System.Console.WriteLine("Playing Destruction Sound {0}", DestructionSound);
            System.Console.WriteLine("Spawing chair Parts");
        }
    }

}