using System;
using DucksPattern.Abitities.Fly;
using DucksPattern.Abitities.Quack;
using DucksPattern.Abitities.Swim;

namespace DucksPattern.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new NoFlying(), new NoQuacking(), new NoSwimming()) {  }

        public override void Display()
        {
            Console.WriteLine("Ложная уточка");
            base.Display();
        }
    }
}