using System;

namespace DucksPattern.Abitities.Quack
{
    public class CanQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Умеет крякать");
        }
    }
}