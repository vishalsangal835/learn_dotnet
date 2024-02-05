using System;
namespace InheritanceDemo2
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearBy;
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarsExplosionSound.mp3";
            DestroyablesNearBy = new List<IDestroyable>();
        }

        // public string DestructionSound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void Destroy()
        {
            System.Console.WriteLine("Playing Destruction Sound {0}", DestructionSound);
            System.Console.WriteLine("Create Fire");

            foreach (IDestroyable destroyable in DestroyablesNearBy)
            {
                destroyable.Destroy();
            }

        }
    }
}