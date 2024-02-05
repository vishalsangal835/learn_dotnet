using System;
namespace InheritanceDemo2
{
    interface IDestroyable
    {
        string DestructionSound { get; set; }
        void Destroy();
    }
}