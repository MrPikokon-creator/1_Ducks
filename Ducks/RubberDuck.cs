using System;
using DucksPattern.Abitities.Fly;
using DucksPattern.Abitities.Quack;
using DucksPattern.Abitities.Swim;

namespace DucksPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFlying(), new CanQuack(), new CanSwim()) { }

        public override void Display()
        {
            Console.WriteLine("Резиновая уточка");
            base.Display();
        }
    }
}