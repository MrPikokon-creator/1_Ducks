using System;

namespace DucksPattern.Abitities.Quack
{
    public class NoQuacking : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Не умеет крякать");
        }
    }
}