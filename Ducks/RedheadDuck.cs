using System;
using DucksPattern.Abitities.Fly;
using DucksPattern.Abitities.Quack;
using DucksPattern.Abitities.Swim;

namespace DucksPattern.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new CanFly(), new CanQuack(), new CanSwim()) { }

        public override void Display()
        {
            Console.WriteLine("Рыжая уточка");
            base.Display();
        }
    }
}