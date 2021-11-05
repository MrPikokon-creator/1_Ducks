using System;

namespace DucksPattern.Abitities.Swim
{
    public class NoSwimming : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("Не умеет плавать");
        }
    }
}