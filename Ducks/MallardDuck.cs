using System;
using DucksPattern.Abitities.Fly;
using DucksPattern.Abitities.Quack;
using DucksPattern.Abitities.Swim;

namespace DucksPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new CanFly(), new NoQuacking(), new CanSwim()) { }

        public override void Display()
        {
            Console.WriteLine("Селезень");
            base.Display();
        }
    }
}