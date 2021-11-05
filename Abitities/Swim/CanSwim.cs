using System;

namespace DucksPattern.Abitities.Swim
{
    public class CanSwim : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("Умеет плавать");
        }
    }
}