using System;

namespace DucksPattern.Abitities.Fly
{
    public class NoFlying : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Не умеет летать");
        }
    }
}